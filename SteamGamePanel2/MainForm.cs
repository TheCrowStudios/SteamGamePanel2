using SteamGamePanelLibrary;
using SteamGamePanelUI;
using System.Security.Cryptography.X509Certificates;

namespace SteamGamePanel2
{
    public partial class MainForm : Form
    {
        enum SandboxPrograms
        {
            Avast,
            Sandboxie
        }

        public Configuration Config { get; set; }
        public List<ISandboxProgram> Sandboxes { get; set; } = new List<ISandboxProgram>();
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            
            bool setup = false;
            
            //sandboxProgramCombo.DataSource = Enum.GetNames(typeof(SandboxPrograms));
            
            if (!Configuration.CheckForConfiguration()) setup = true;
            Config = Configuration.LoadConfig();
            Config.SaveConfig();

            Sandboxes.Add(new Avast());
            Sandboxes.Add(new Sandboxie(Config.SandboxiePath));

            for (int i = 0; i < Sandboxes.Count; i++)
            {
                sandboxProgramCombo.Items.Add(Sandboxes[i].Title);
            }

            sandboxProgramCombo.SelectedIndex = 0;

            UpdateUserList();
            versionLabel.Text = Themes.Version;
            Themes.SetFormTheme(this);
            splashForm.Close();

            if (setup)
            {
                SetupForm form = new SetupForm(Config);
                form.ShowDialog();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(Config);
            form.ShowDialog();
            UpdateUserList();
        }

        private void editAccountsButton_Click(object sender, EventArgs e)
        {
            EditAccountsForm form = new EditAccountsForm(Config);
            form.ShowDialog();
            UpdateUserList();
        }

        private void accountsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateUserList()
        {
            accountsList.Items.Clear();
            
            for (int i = 0; i < Config.SteamUsers.Count; i++)
            {
                accountsList.Items.Add(Config.SteamUsers[i].Username);
                accountsList.Items[i].SubItems.Add($"{Config.SteamUsers[i].GameProcess?.Id.ToString()} - {Config.SteamUsers[i].GameProcess?.MainWindowTitle}");
                accountsList.Items[i].SubItems.Add($"{Config.SteamUsers[i].Status}");
            }
        }

        private void launchSteamButton_Click(object sender, EventArgs e)
        {
            List<SteamUserModel> accountsToLaunch = GetAccountsToLaunch();

            Sandboxes[sandboxProgramCombo.SelectedIndex].LaunchSteamAndLoginInSandbox(accountsToLaunch, Config.SteamPath);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateUserList();
        }

        private void launchGameButton_Click(object sender, EventArgs e)
        {
            List<SteamUserModel> accountsToLaunch = GetAccountsToLaunch();

            Sandboxes[sandboxProgramCombo.SelectedIndex].LaunchSteamGameInSandbox(accountsToLaunch, Config.SteamPath, Config.GameID, Config.GameWindowWidth, Config.GameWindowHeight, Config.ScreenWidth, Config.ScreenHeight, Config.GameServerIP, Config.GameServerPort);

            if (!Config.ScanUserInventory) return;

            for (int i = 0; i < accountsToLaunch.Count; i++)
            {
                accountsToLaunch[i].StartSearchingForNewInventoryItems(Config.TimeBetweenInventoryRequest);
            }
        }

        public List<SteamUserModel> GetAccountsToLaunch()
        {
            List<SteamUserModel> accountsToLaunch = new List<SteamUserModel>();

            if (accountsList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < accountsList.SelectedItems.Count; i++)
                {
                    accountsToLaunch.Add(Config.SteamUsers[accountsList.SelectedIndices[i]]);
                }
            }
            else accountsToLaunch = Config.SteamUsers;

            return accountsToLaunch;
        }

        private void donateLabel_Click(object sender, EventArgs e)
        {
            DonateForm form = new DonateForm();
            form.Show();
        }

        private void creditsLabel_Click(object sender, EventArgs e)
        {
            CreditsForm form = new CreditsForm();
            form.Show();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            UpdateUserList();
        }
    }
}