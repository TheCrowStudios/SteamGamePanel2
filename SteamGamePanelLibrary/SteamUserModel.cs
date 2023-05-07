using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SteamGamePanelLibrary
{
    public class SteamUserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SharedSecret { get; set; }
        public string SteamID { get; set; }
        [JsonIgnore]
        public string SteamInventory { get; set; }
        [JsonIgnore]
        public string Inventory { get; set; }
        [JsonIgnore]
        public string Status { get; set; }
        [JsonIgnore]
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

        public void StartSearchingForNewInventoryItems(int _timeBetweenInventoryRequest)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(SearchForNewinventoryItemsInThread));
            thread.Start(_timeBetweenInventoryRequest);
        }

        void SearchForNewinventoryItemsInThread(object _timeBetweenInventoryRequest)
        {
            int timeBetweenInventoryRequest = (int)_timeBetweenInventoryRequest;

            if (SteamID == null) return;

            Inventory = SteamWebRequest.GetUserInventory(this);

            // DONE - Check if a case is added.


            Thread.Sleep(60000);
            
            while (true)
            {
                if (GameProcess.HasExited) return;
                
                string? newInventory = SteamWebRequest.GetUserInventory(this);

                if (newInventory != null)
                {
                    if (newInventory != Inventory)
                    {
                        Inventory = newInventory;
                        GameProcess.Kill();
                        return;
                    }

                    Thread.Sleep(timeBetweenInventoryRequest);
                }
            }
        }
    }
}
