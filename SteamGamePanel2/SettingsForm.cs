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
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(presetCombo, "Preset for the timings. Select fast if you have a fast computer and are not experiencing issues with launching Steam.");
            toolTip.SetToolTip(accountDelayText, "The delay in ms between each account being launched");
            toolTip.SetToolTip(launchSpanText, "The time in ms used to identify the associated Steam process with an account.");
            toolTip.SetToolTip(inputDelayText, "The delay in ms between text entry.");

            accountDelayText.Text = Config.AccountDelay.ToString();
            launchSpanText.Text = Config.ProcessLaunchSpan.ToString();
            inputDelayText.Text = Config.TextInputDelay.ToString();
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

            presetCombo.Items.Add("Fast");
            presetCombo.Items.Add("Medium");
            presetCombo.Items.Add("Slow");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(accountDelayText.Text, out value)) Config.AccountDelay = value;
            if (int.TryParse(launchSpanText.Text, out value)) Config.ProcessLaunchSpan = value;
            if (int.TryParse(inputDelayText.Text, out value)) Config.TextInputDelay = value;
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

            if (!int.TryParse(accountDelayText.Text, out value)) accountDelayLabel.ForeColor = Color.Red;
            if (!int.TryParse(launchSpanText.Text, out value)) launchSpanLabel.ForeColor = Color.Red;
            if (!int.TryParse(inputDelayText.Text, out value)) inputDelayLabel.ForeColor = Color.Red;
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

        private void presetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (presetCombo.SelectedIndex)
            {
                case 0:
                    accountDelayText.Text = "500";
                    launchSpanText.Text = "250";
                    inputDelayText.Text = "100";
                    break;
                case 1:
                    accountDelayText.Text = "1000";
                    launchSpanText.Text = "500";
                    inputDelayText.Text = "150";
                    break;
                case 2:
                    accountDelayText.Text = "1500";
                    launchSpanText.Text = "750";
                    inputDelayText.Text = "200";
                    break;
            }
        }
    }
}
