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

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            steamPathText.Text = Config.SteamPath;
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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int value;

            Config.SteamPath = steamPathText.Text;
            Config.SandboxiePath = sandboxiePathText.Text;
            Config.SandboxieConfigurationPath = sandboxieConfigurationPathText.Text;
            Config.GameID = gameIDText.Text;
            if (int.TryParse(gameWidthText.Text, out value)) Config.GameWindowWidth = value;
            else gameWidthLabel.ForeColor = Color.Red;
            if (int.TryParse(gameHeightText.Text, out value)) Config.GameWindowHeight = value;
            else gameHeightLabel.ForeColor = Color.Red;
            Config.GameServerIP = gameIPText.Text;
            Config.GameServerPort = gamePortText.Text;
            if (int.TryParse(monitorWidthText.Text, out value)) Config.ScreenWidth = value;
            else monitorWidthLabel.ForeColor = Color.Red;
            if (int.TryParse(monitorHeightText.Text, out value)) Config.ScreenHeight = value;
            else monitorHeightLabel.ForeColor = Color.Red;
            Config.MaFilesPath = maFilesPathText.Text;
            Config.SaveConfig();
            UpdateColors();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Config = Configuration.LoadConfig();
            Close();
        }

        void UpdateColors()
        {
            int value;

            gameIDLabel.ForeColor = ForeColor;
            gameWidthLabel.ForeColor = ForeColor;
            gameHeightLabel.ForeColor = ForeColor;
            monitorWidthLabel.ForeColor = ForeColor;
            monitorHeightLabel.ForeColor = ForeColor;
            steamPathLabel.ForeColor = ForeColor;
            sandboxiePathLabel.ForeColor = ForeColor;
            sandboxieConfigurationPathLabel.ForeColor = ForeColor;
            maFilesPathLabel.ForeColor = ForeColor;

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
