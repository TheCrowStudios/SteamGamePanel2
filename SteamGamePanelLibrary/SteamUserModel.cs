using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanelLibrary
{
    public class SteamUserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SharedSecret { get; set; }
        public string SteamID { get; set; }
        public string SteamInventory { get; set; }
        public Process GameProcess { get; set; }

        public SteamUserModel()
        {

        }

        public SteamUserModel(string _username, string _password)
        {
            Username = _username;
            Password = _password;
        }

        public SteamUserModel(string _username, string _password, string _sharedSecret, string _steamID)
        {
            Username = _username;
            Password = _password;
            SharedSecret = _sharedSecret;
            SteamID = _steamID;
        }
    }
}
