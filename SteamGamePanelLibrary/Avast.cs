using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanelLibrary
{
   public class Avast : ISandboxProgram
    {
        public string Title { get; set; } = "Avast";

        public Avast()
        {
            
        }

        public void LaunchSteamAndLoginInSandbox(SteamUserModel _account, string _steamLauncher)
        {
            Process avast = new Process();

            avast.StartInfo.FileName = _steamLauncher;
            avast.StartInfo.Arguments = $"-login {_account.Username} {_account.Password}";
            avast.Start();
            _account.GameProcess = avast;
            _account.Status = "Launching in Avast";
        }

        // DONE - Use threads to add time between users launching.
        public void LaunchSteamAndLoginInSandbox(List<SteamUserModel> _accounts, string _steamLauncher)
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
            //ReloadSandboxie(SandboxiePath);
            Process avast = new Process();

            avast.StartInfo.FileName = _steamLauncher;
            avast.StartInfo.Arguments = $"-login {_account.Username} {_account.Password} -applaunch {_gameID} -sw -w {_windowWidth} -h {_windowHeight} -x {_posX} -y {_posY} ";

            if (_ip != null && _port != null) avast.StartInfo.Arguments += $"+sv_upload +connect {_ip} +port {_port}";

            avast.Start();
            _account.GameProcess = avast;
            _account.Status = "Launching in Avast";
        }

        public void LaunchSteamGameInSandbox(List<SteamUserModel> _accounts, string _steamLauncher, string _gameID, int _windowWidth, int _windowHeight, int _monitorWidth, int _monitorHeight, string? _ip, string? _port)
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
