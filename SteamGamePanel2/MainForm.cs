using SteamGamePanelLibrary;
using SteamGamePanelUI;

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
        public Sandboxie SandboxieProgram { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            
            bool setup = false;
            
            sandboxProgramCombo.DataSource = Enum.GetNames(typeof(SandboxPrograms));
            
            if (!Configuration.CheckForConfiguration()) setup = true;
            Config = Configuration.LoadConfig();
            Config.SaveConfig();

            if (setup)
            {
                SetupForm form = new SetupForm(Config);
                form.ShowDialog();
            }

            SandboxieProgram = new Sandboxie(Config.SandboxiePath);

            UpdateUserList();
            Themes.SetFormTheme(this);
            splashForm.Close();
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
            }
        }

        private void launchSteamButton_Click(object sender, EventArgs e)
        {
            List<SteamUserModel> accountsToLaunch = GetAccountsToLaunch();

            switch (sandboxProgramCombo.SelectedIndex)
            {
                case (int)SandboxPrograms.Avast:
                    break;

                case (int)SandboxPrograms.Sandboxie:
                    SandboxieProgram.LaunchSteamAndLoginAccountsInSandbox(accountsToLaunch, Config.SteamPath);
                    break;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateUserList();
        }

        private void launchGameButton_Click(object sender, EventArgs e)
        {
            List<SteamUserModel> accountsToLaunch = GetAccountsToLaunch();

            switch (sandboxProgramCombo.SelectedIndex)
            {
                case (int)SandboxPrograms.Avast:
                    break;

                case (int)SandboxPrograms.Sandboxie:
                    SandboxieProgram.LaunchSteamGamesInSandbox(accountsToLaunch, Config.SteamPath, Config.GameID, Config.GameWindowWidth, Config.GameWindowHeight, Config.ScreenWidth, Config.ScreenHeight, Config.GameServerIP, Config.GameServerPort);
                    break;
            }

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
    }
}