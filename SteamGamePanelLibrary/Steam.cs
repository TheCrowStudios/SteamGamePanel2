﻿using SteamAuth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace SteamGamePanelLibrary
{
    public class Steam
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static Configuration Config { get; set; }

        public static void LaunchSteamAndLogin(SteamUserModel _account)
        {
            Process steam = new Process();
        }

        /// <summary>
        /// Creates a thread on which it looks for a Steam sign in window for the specified Steam user and generates a Steam guard code which it enters into the Steam window.
        /// </summary>
        /// <param name="_account"></param>
        public static void EnterSteamGuard(SteamUserModel _account)
        {
            Thread thread = new Thread(EnterSteamGuardInThread);
            thread.Start(_account);
        }

        // TODO - Add input settings.
        static void EnterSteamGuardInThread(object _account)
        {
            SteamUserModel user = (SteamUserModel)_account;

            if (user.SharedSecret == null)
            {
                user.Status = "No maFile";
                return;
            }

            Process steamProcess = new Process();
            bool steamProcessFound = false;

            user.Status = "Finding Steam guard window.";

            int attempts = 0;

            while (attempts < 10 && !steamProcessFound)
            {
                Process[] steamProcesses = Process.GetProcessesByName("Steam");

                for (int i = 0; i < steamProcesses.Length; i++)
                {
                    if (!steamProcesses[i].HasExited)
                    {
                        TimeSpan timeSpan = steamProcesses[i].StartTime - user.GameProcess.StartTime;

                        if (steamProcesses[i].MainWindowTitle.Contains("Steam Sign In") && timeSpan < TimeSpan.FromMilliseconds(Config.ProcessLaunchSpan))
                        {
                            steamProcess = steamProcesses[i];
                            steamProcessFound = true;
                            user.GameProcess = steamProcess;
                            break;
                        }
                    }
                }

                attempts += 1;
                Thread.Sleep(5000);
            }

            if (!steamProcessFound)
            {
                user.Status = "Could not find steam process.";
                return;
            }
            
            user.Status = "Entering Steam guard.";
            
            attempts = 0;

            // DONE - Fix attempt to enter steam guard for multiple accounts at the same time.
            // TODO - Fix program crashing if Steam is closed while trying to enter Steam guard.
            while (attempts < 3)
            {
                SteamGuardAccount steamGuardAccount = new SteamGuardAccount();
                steamGuardAccount.SharedSecret = user.SharedSecret;
                string steamGuardCode = steamGuardAccount.GenerateSteamGuardCode();
                SetForegroundWindow(steamProcess.MainWindowHandle);
                Thread.Sleep(Config.TextInputDelay);
                InputSimulator inputSimulator = new InputSimulator();
                inputSimulator.Keyboard.TextEntry(steamGuardCode);
                inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);

                Thread.Sleep(5000);

                if (!steamProcess.MainWindowTitle.Contains("Steam Sign In"))
                {
                    user.Status = "Steam guard entered.";
                    return;
                }

                attempts += 1;
            }

            user.Status = "Could not enter Steam guard.";
        }

        /// <summary>
        /// Creates a thread on which it enters the Steam guard codes for the specified Steam users one at a time.
        /// </summary>
        /// <param name="_accounts"></param>
        public static void EnterSteamGuardCodes(List<SteamUserModel> _accounts)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(EnterSteamGuardCodesInThread));
            thread.Start(_accounts);
        }

        static void EnterSteamGuardCodesInThread(object _accounts)
        {
            List<SteamUserModel> accounts = (List<SteamUserModel>)_accounts;

            for (int i = 0; i < accounts.Count; i++)
            {
                EnterSteamGuardInThread(accounts[i]);
            }
        }
    }
}
