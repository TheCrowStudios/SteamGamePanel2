using Newtonsoft.Json.Linq;
using SteamGamePanelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGamePanelUI
{
    public partial class SettingsForm : Form
    {
        public Configuration Config { get; set; }

        public SettingsForm(Configuration _configuration)
        {
            InitializeComponent();
            Config = _configuration;
        }

        // TODO - Add tooltips.
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            steamPathText.Text = Config.SteamPath;
            inventoryRequestTimeText.Text = Config.TimeBetweenInventoryRequest.ToString();
            scanUserInventoryCheck.Checked = Config.ScanUserInventory;
            sandboxiePathText.Text = Config.SandboxiePath;
            sandboxieConfigurationPathText.Text = Config.SandboxieConfigurationPath;
            gameIDText.Text = Config.GameID;
            gameWidthText.Text = Config.GameWindowWidth.ToString();
            gameHeightText.Text = Config.GameWindowHeight.ToString();
            gameIPText.Text = Config.GameServerIP;
            gamePortText.Text = Config.GameServerPort;
            monitorWidthText.Text = Config.ScreenWidth.ToString();
            monitorHeightText.Text = Config.ScreenHeight.ToString();
            maFilesPathText.Text = Config.MaFilesPath;
            UpdateColors();
            Themes.SetFormTheme(this);

            notifyLabel.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int value;

            Config.SteamPath = steamPathText.Text;
            if (int.TryParse(inventoryRequestTimeText.Text, out value)) Config.TimeBetweenInventoryRequest = value;
            Config.ScanUserInventory = scanUserInventoryCheck.Checked;
            Config.SandboxiePath = sandboxiePathText.Text;
            Config.SandboxieConfigurationPath = sandboxieConfigurationPathText.Text;
            Config.GameID = gameIDText.Text;
            if (int.TryParse(gameWidthText.Text, out value)) Config.GameWindowWidth = value;
            if (int.TryParse(gameHeightText.Text, out value)) Config.GameWindowHeight = value;
            Config.GameServerIP = gameIPText.Text;
            Config.GameServerPort = gamePortText.Text;
            if (int.TryParse(monitorWidthText.Text, out value)) Config.ScreenWidth = value;
            if (int.TryParse(monitorHeightText.Text, out value)) Config.ScreenHeight = value;
            Config.MaFilesPath = maFilesPathText.Text;
            Config.SaveConfig();
            UpdateColors();

            notifyLabel.Text = "Saved";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Config = Configuration.LoadConfig();
            Close();
        }

        void UpdateColors()
        {
            int value;

            inventoryRequestTimeLabel.ForeColor = ForeColor;
            gameIDLabel.ForeColor = ForeColor;
            gameWidthLabel.ForeColor = ForeColor;
            gameHeightLabel.ForeColor = ForeColor;
            monitorWidthLabel.ForeColor = ForeColor;
            monitorHeightLabel.ForeColor = ForeColor;
            steamPathLabel.ForeColor = ForeColor;
            sandboxiePathLabel.ForeColor = ForeColor;
            sandboxieConfigurationPathLabel.ForeColor = ForeColor;
            maFilesPathLabel.ForeColor = ForeColor;

            if (!int.TryParse(inventoryRequestTimeText.Text, out value)) inventoryRequestTimeLabel.ForeColor = Color.Red;
            if (!File.Exists(steamPathText.Text)) steamPathLabel.ForeColor = Color.Red;
            if (!File.Exists(sandboxiePathText.Text) && sandboxiePathText.Text != "") sandboxiePathLabel.ForeColor = Color.Red;
            if (!File.Exists(sandboxieConfigurationPathText.Text) && sandboxieConfigurationPathText.Text != "") sandboxieConfigurationPathLabel.ForeColor = Color.Red;
            if (!Directory.Exists(maFilesPathText.Text)) maFilesPathLabel.ForeColor = Color.Red;
            if (gameIDText.Text == "") gameIDLabel.ForeColor = Color.Red;
            if (!int.TryParse(gameWidthText.Text, out value)) gameWidthLabel.ForeColor = Color.Red;
            if (!int.TryParse(gameHeightText.Text, out value)) gameHeightLabel.ForeColor = Color.Red;
            if (!int.TryParse(monitorWidthText.Text, out value)) monitorWidthLabel.ForeColor = Color.Red;
            if (!int.TryParse(monitorHeightText.Text, out value)) monitorHeightLabel.ForeColor = Color.Red;
        }
    }
}
