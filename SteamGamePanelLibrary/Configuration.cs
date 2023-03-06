using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace SteamGamePanelLibrary
{
    public class Configuration
    {
        /// <summary>
        /// The path to the configuration JSON file.
        /// </summary>
        [JsonIgnore]
        public static string ConfigFilePath { get; set; } = "config.json";
        /// <summary>
        /// The path of the Steam exe from the registry that is set when config is loaded.
        /// </summary>
        public string SteamPath { get; set; }
        /// <summary>
        /// Directory containing steam user maFiles.
        /// </summary>
        public string MaFilesPath { get; set; }
        /// <summary>
        /// Sandboxie exe path.
        /// </summary>
        public string SandboxiePath { get; set; }
        /// <summary>
        /// Sandboxie configuration file path.
        /// </summary>
        public string SandboxieConfigurationPath { get; set; }
        public string GameID { get; set; } = "730";
        /// <summary>
        /// IP of the game server to pass as an argument to Steam.
        /// </summary>
        public string GameServerIP { get; set; } = "192.168.0.1";
        /// <summary>
        /// Port of the game server to pass as an argument to Steam.
        /// </summary>
        public string GameServerPort { get; set; } = "27015";
        /// <summary>
        /// The width of the monitor.
        /// </summary>
        public int ScreenWidth { get; set; } = 1080;
        /// <summary>
        /// The height of the monitor.
        /// </summary>
        public int ScreenHeight { get; set; } = 720;
        public int GameWindowWidth { get; set; } = 320;
        public int GameWindowHeight { get; set; } = 240;
        public int TimeBetweenInventoryRequest { get; set; } = 60000;
        public bool ScanUserInventory { get; set; } = true;
        /// <summary>
        /// The loaded steam accounts from the file.
        /// </summary>
        public List<SteamUserModel> SteamUsers { get; set; } = new List<SteamUserModel>();

        public Configuration()
        {
            RegistryKey steamRegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");

            if (steamRegistryKey != null) SteamPath = steamRegistryKey.GetValue("SteamExe").ToString();

            if (File.Exists("C:\\Program Files\\Sandboxie-Plus\\Start.exe")) SandboxiePath = "C:\\Program Files\\Sandboxie-Plus\\Start.exe";
            if (File.Exists("C:\\Windows\\Sandboxie.ini")) SandboxieConfigurationPath = "C:\\Windows\\Sandboxie.ini";
        }
        
        /// <summary>
        /// Loads settings from JSON file and returns a new Configuration instance.
        /// </summary>
        public static Configuration LoadConfig()
        {
            if (!File.Exists(ConfigFilePath))
            {
                return new Configuration();
            }
            
            return ConfigurationFromFile();
        }

        /// <summary>
        /// Saves the current configuration to file.
        /// </summary>
        public void SaveConfig()
        {
            string serializedObject = JsonConvert.SerializeObject(this);

            using (StreamWriter sw = new StreamWriter(ConfigFilePath))
            {
                sw.Write(serializedObject);
            }
        }

        /// <summary>
        /// Checks if the configuration file exists.
        /// </summary>
        /// <returns></returns>
        public static bool CheckForConfiguration()
        {
            if (!File.Exists(ConfigFilePath)) return false;
            return true;
        }

        static Configuration ConfigurationFromFile()
        {
            string jsonFile;

            using (StreamReader sr = new StreamReader(ConfigFilePath))
            {
                jsonFile = sr.ReadToEnd();
            }

            Configuration configuration = JsonConvert.DeserializeObject<Configuration>(jsonFile);
            configuration.ScanMaFilesAndUpdateUsers();
            return configuration;
        }

        
        /// <summary>
        /// Adds the user to the configuration, creates a box in sandboxie for the user and saves the configuration.
        /// </summary>
        /// <param name="_username"></param>
        /// <param name="_password"></param>
        /// <returns></returns>
        public bool AddSteamUser(string _username, string _password)
        {
            for (int i = 0; i < SteamUsers.Count; i++)
            {
                if (SteamUsers[i].Username == _username) return false;
            }
            
            SteamUsers.Add(new SteamUserModel(_username, _password));
            Sandboxie.CreateBox(_username, SandboxiePath, SandboxieConfigurationPath);
            ScanMaFilesAndUpdateUsers();
            SaveConfig();
            return true;
        }

        /// <summary>
        /// Removes the user from the configuration, removes the user box in Sandboxie and saves the configuration.
        /// </summary>
        /// <param name="_username"></param>
        public void RemoveSteamUser(string _username)
        {
            for (int i = 0; i < SteamUsers.Count; i++)
            {
                if (SteamUsers[i].Username == _username) SteamUsers.RemoveAt(i);
            }

            Sandboxie.RemoveBox(_username, SandboxiePath);
            SaveConfig();
        }

        /// <summary>
        /// Goes through all the maFiles files in the maFile directory, parses them and sets the shared secret and steam ID of the users.
        /// </summary>
        public void ScanMaFilesAndUpdateUsers()
        {
            if (!Directory.Exists(MaFilesPath)) return;

            string[] maFiles = Directory.GetFiles(MaFilesPath, "*.maFile");

            for (var i = 0; i < maFiles.Length; i++)
            {
                string maFile;

                using (StreamReader sr = new StreamReader(maFiles[i]))
                {
                    maFile = sr.ReadToEnd();
                }

                JObject jObject = JObject.Parse(maFile);
                string username = jObject.Value<string>("account_name");

                for (var j = 0; j < SteamUsers.Count; j++)
                {
                    if (SteamUsers[j].Username == username)
                    {
                        SteamUsers[j].SharedSecret = (string)jObject["shared_secret"];
                        SteamUsers[j].SteamID = (string)jObject["Session"]["SteamID"];
                        break;
                    }
                }
            }
        }
    }
}