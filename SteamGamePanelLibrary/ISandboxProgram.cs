using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanelLibrary
{
    internal interface ISandboxProgram
    {
        /// <summary>
        /// Launches a Steam account in sandbox and logs in.
        /// </summary>
        /// <param name="_account"></param>
        /// <param name="_steamLauncher"></param>
        public void LaunchSteamAndLoginInSandbox(SteamUserModel _account, string _steamLauncher);
        /// <summary>
        /// Launches multiple Steam accounts in sandbox and logs in.
        /// </summary>
        /// <param name="_accounts"></param>
        /// <param name="_steamLauncher"></param>
        public void LaunchSteamAndLoginAccountsInSandbox(List<SteamUserModel> _accounts, string _steamLauncher);
        /// <summary>
        /// Launches a Steam game in a sandbox on an account.
        /// </summary>
        /// <param name="_account"></param>
        /// <param name="_steamLauncher"></param>
        /// <param name="_gameID"></param>
        /// <param name="_windowWidth"></param>
        /// <param name="_windowHeight"></param>
        /// <param name="_posX"></param>
        /// <param name="_posY"></param>
        /// <param name="_ip"></param>
        /// <param name="_port"></param>
        public void LaunchSteamGameInSandbox(SteamUserModel _account, string _steamLauncher, string _gameID, int _windowWidth, int _windowHeight, int _posX, int _posY, string? _ip, string? _port);
        /// <summary>
        /// Launches multiple Steam games in a sandbox on different accounts.
        /// </summary>
        /// <param name="_accounts"></param>
        /// <param name="_steamLauncher"></param>
        /// <param name="_gameID"></param>
        /// <param name="_windowWidth"></param>
        /// <param name="_windowHeight"></param>
        /// <param name="_monitorWidth"></param>
        /// <param name="_monitorHeight"></param>
        /// <param name="_ip"></param>
        /// <param name="_port"></param>
        public void LaunchSteamGamesInSandbox(List<SteamUserModel> _accounts, string _steamLauncher, string _gameID, int _windowWidth, int _windowHeight, int _monitorWidth, int _monitorHeight, string? _ip, string? _port);
    }
}
