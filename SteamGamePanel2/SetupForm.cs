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
    public partial class SetupForm : Form
    {
        public Configuration Config { get; set; }

        public SetupForm(Configuration _configuration)
        {
            InitializeComponent();
            Config = _configuration;
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            Themes.SetFormTheme(this);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            SettingsForm settingsForm = new SettingsForm(Config);
            settingsForm.ShowDialog();
            EditAccountsForm accountsForm = new EditAccountsForm(Config);
            accountsForm.ShowDialog();
            Close();
        }

        private void donateLabel_Click(object sender, EventArgs e)
        {
            DonateForm form = new DonateForm();
            form.Show();
        }
    }
}
