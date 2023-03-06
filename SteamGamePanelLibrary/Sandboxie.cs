using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanelLibrary
{
    public class Sandboxie : ISandboxProgram
    {
        public string SandboxiePath { get; set; }

        public Sandboxie(string _sandboxiePath)
        {
            SandboxiePath = _sandboxiePath;
        }

        public static void CreateBox(string _title, string _sandboxiePath, string _configurationPath)
        {
            if (!File.Exists(_configurationPath)) return;
            
            string configuration;
            
            using (StreamReader sr = new StreamReader(_configurationPath))
            {
                configuration = sr.ReadToEnd();
            }

            using (StreamWriter sw = new StreamWriter(_configurationPath, true, Encoding.Unicode))
            {
                if (!configuration.Contains($"[{_title}]"))
                {
                    sw.WriteLine($"[{_title}]\nEnabled=y\nBlockNetworkFiles=y\nRecoverFolder=%{{374DE290-123F-4565-9164-39C4925E467B}}%\nRecoverFolder=%Personal%\nRecoverFolder=%Desktop%\nBorderColor=#02f6f6,ttl\nTemplate=OpenBluetooth\nTemplate=SkipHook\nTemplate=FileCopy\nTemplate=qWave\nTemplate=BlockPorts\nTemplate=LingerPrograms\nTemplate=AutoRecoverIgnore\nConfigLevel=9\nAutoRecover=y\nUseSecurityMode=n\nUsePrivacyMode=n\nOpenPipePath=D:\\SteamLibrary\n");
                }
            }

            ReloadSandboxie(_sandboxiePath);
        }

        public static void RemoveBox(string _title, string _sandboxiePath)
        {
            Process sandboxie = new Process();

            sandboxie.StartInfo.FileName = _sandboxiePath;
            sandboxie.StartInfo.Arguments = $"/box:{_title} delete_sandbox";
            sandboxie.Start();
        }

        public static void ReloadSandboxie(string _sandboxiePath)
        {
            Process sandboxie = new Process();

            sandboxie.StartInfo.FileName = _sandboxiePath;
            sandboxie.StartInfo.Arguments = $"/reload";
            sandboxie.Start();
        }

        public void LaunchSteamAndLoginInSandbox(SteamUserModel _account, string _steamLauncher)
        {
            ReloadSandboxie(SandboxiePath);
            Process sandboxie = new Process();

            sandboxie.StartInfo.FileName = SandboxiePath;
            sandboxie.StartInfo.Arguments = $"/box:{_account.Username} {_steamLauncher} -login {_account.Username} {_account.Password}";
            sandboxie.Start();
            _account.GameProcess = sandboxie;
        }

        // DONE - Use threads to add time between users launching.
        public void LaunchSteamAndLoginAccountsInSandbox(List<SteamUserModel> _accounts, string _steamLauncher)
        {
            Thread thread = new Thread(() => LaunchSteamAndLoginAccountsInSandboxInThread(_accounts, _steamLauncher));
            thread.Start();
        }

        void LaunchSteamAndLoginAccountsInSandboxInThread(List<SteamUserModel> _accounts, string _steamLauncher)
        {
            for (int i = 0; i < _accounts.Count; i++)
            {
                LaunchSteamAndLoginInSandbox(_accounts[i], _steamLauncher);
                Thread.Sleep(1000);
            }

            Steam.EnterSteamGuardCodes(_accounts);
        }

        public void LaunchSteamGameInSandbox(SteamUserModel _account, string _steamLauncher, string _gameID, int _windowWidth, int _windowHeight, int _posX, int _posY, string? _ip, string? _port)
        {
            ReloadSandboxie(SandboxiePath);
            Process sandboxie = new Process();

            sandboxie.StartInfo.FileName = SandboxiePath;
            sandboxie.StartInfo.Arguments = $"/box:{_account.Username} {_steamLauncher} -login {_account.Username} {_account.Password} -applaunch {_gameID} -sw -w {_windowWidth} -h {_windowHeight} -x {_posX} -y {_posY} ";

            if (_ip != null && _port != null) sandboxie.StartInfo.Arguments += $"+sv_upload +connect {_ip} +port {_port}";

            sandboxie.Start();
            _account.GameProcess = sandboxie;
        }

        public void LaunchSteamGamesInSandbox(List<SteamUserModel> _accounts, string _steamLauncher, string _gameID, int _windowWidth, int _windowHeight, int _monitorWidth, int _monitorHeight, string? _ip, string? _port)
        {
            int widthUsed = 0;
            int heightUsed = 0;

            for (int i = 0; i < _accounts.Count; i++)
            {
                LaunchSteamGameInSandbox(_accounts[i], _steamLauncher, _gameID, _windowWidth, _windowHeight, i * widthUsed, heightUsed, _ip, _port);
                widthUsed += _windowWidth;

                if (widthUsed + _windowWidth > _monitorWidth)
                {
                    heightUsed += _windowHeight;
                    widthUsed = 0;
                }

                Thread.Sleep(1000);
            }

            Steam.EnterSteamGuardCodes(_accounts);
        }
    }
}
