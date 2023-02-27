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

        static void EnterSteamGuardInThread(object _account)
        {
            SteamUserModel user = (SteamUserModel)_account;
            Process steamProcess = new Process();
            bool steamProcessFound = false;

            int attempts = 0;

            while (attempts < 10 && !steamProcessFound)
            {
                Process[] steamProcesses = Process.GetProcessesByName("Steam");

                if (steamProcesses.Length == 0) return;

                for (int i = 0; i < steamProcesses.Length; i++)
                {
                    if (steamProcesses[i].MainWindowTitle == "[#] Steam Sign In [#]" && steamProcesses[i].StartTime - user.GameProcess.StartTime < TimeSpan.FromMilliseconds(500))
                    {
                        steamProcess = steamProcesses[i];
                        steamProcessFound = true;
                        break;
                    }
                    else if (i == steamProcesses.Length - 1 && attempts >= 10 && !steamProcessFound) return;
                }

                attempts += 1;
                Thread.Sleep(5000);
            }

            attempts = 0;

            // TODO - Fix attempt to enter steam guard for multiple accounts at the same time.
            while (attempts < 3)
            {
                SteamGuardAccount steamGuardAccount = new SteamGuardAccount();
                steamGuardAccount.SharedSecret = user.SharedSecret;
                string steamGuardCode = steamGuardAccount.GenerateSteamGuardCode();
                SetForegroundWindow(steamProcess.MainWindowHandle);
                Thread.Sleep(50);
                InputSimulator inputSimulator = new InputSimulator();
                inputSimulator.Keyboard.TextEntry(steamGuardCode);
                inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
                user.GameProcess = steamProcess;
                if (steamProcess.MainWindowTitle != "[#] Steam Sign In [#]") return;
                Thread.Sleep(5000);
                attempts += 1;
            }
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
