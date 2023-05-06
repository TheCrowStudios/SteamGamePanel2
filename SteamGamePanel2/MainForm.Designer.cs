namespace SteamGamePanel2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.launchSteamButton = new System.Windows.Forms.Button();
            this.launchGameButton = new System.Windows.Forms.Button();
            this.accountsList = new System.Windows.Forms.ListView();
            this.usernameHeader = new System.Windows.Forms.ColumnHeader();
            this.processIDHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.editAccountsButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.sandboxProgramCombo = new System.Windows.Forms.ComboBox();
            this.sandboxProgramLabel = new System.Windows.Forms.Label();
            this.donateLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // launchSteamButton
            // 
            this.launchSteamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchSteamButton.Location = new System.Drawing.Point(41, 320);
            this.launchSteamButton.Name = "launchSteamButton";
            this.launchSteamButton.Size = new System.Drawing.Size(130, 50);
            this.launchSteamButton.TabIndex = 0;
            this.launchSteamButton.Text = "Launch Steam";
            this.launchSteamButton.UseVisualStyleBackColor = true;
            this.launchSteamButton.Click += new System.EventHandler(this.launchSteamButton_Click);
            // 
            // launchGameButton
            // 
            this.launchGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchGameButton.Location = new System.Drawing.Point(177, 320);
            this.launchGameButton.Name = "launchGameButton";
            this.launchGameButton.Size = new System.Drawing.Size(130, 50);
            this.launchGameButton.TabIndex = 1;
            this.launchGameButton.Text = "Launch game";
            this.launchGameButton.UseVisualStyleBackColor = true;
            this.launchGameButton.Click += new System.EventHandler(this.launchGameButton_Click);
            // 
            // accountsList
            // 
            this.accountsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accountsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameHeader,
            this.processIDHeader,
            this.statusHeader});
            this.accountsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.accountsList.Location = new System.Drawing.Point(345, 81);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(443, 233);
            this.accountsList.TabIndex = 2;
            this.accountsList.UseCompatibleStateImageBehavior = false;
            this.accountsList.View = System.Windows.Forms.View.Details;
            this.accountsList.SelectedIndexChanged += new System.EventHandler(this.accountsList_SelectedIndexChanged);
            // 
            // usernameHeader
            // 
            this.usernameHeader.Text = "Username";
            this.usernameHeader.Width = 128;
            // 
            // processIDHeader
            // 
            this.processIDHeader.Text = "Process ID";
            this.processIDHeader.Width = 128;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 128;
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.Location = new System.Drawing.Point(345, 57);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(73, 21);
            this.accountsLabel.TabIndex = 4;
            this.accountsLabel.Text = "Accounts";
            // 
            // settingsButton
            // 
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(481, 320);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(130, 50);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // editAccountsButton
            // 
            this.editAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccountsButton.Location = new System.Drawing.Point(345, 320);
            this.editAccountsButton.Name = "editAccountsButton";
            this.editAccountsButton.Size = new System.Drawing.Size(130, 50);
            this.editAccountsButton.TabIndex = 5;
            this.editAccountsButton.Text = "Edit accounts";
            this.editAccountsButton.UseVisualStyleBackColor = true;
            this.editAccountsButton.Click += new System.EventHandler(this.editAccountsButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(617, 320);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(130, 50);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // sandboxProgramCombo
            // 
            this.sandboxProgramCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sandboxProgramCombo.FormattingEnabled = true;
            this.sandboxProgramCombo.Location = new System.Drawing.Point(41, 285);
            this.sandboxProgramCombo.Name = "sandboxProgramCombo";
            this.sandboxProgramCombo.Size = new System.Drawing.Size(121, 29);
            this.sandboxProgramCombo.TabIndex = 17;
            // 
            // sandboxProgramLabel
            // 
            this.sandboxProgramLabel.AutoSize = true;
            this.sandboxProgramLabel.Location = new System.Drawing.Point(36, 261);
            this.sandboxProgramLabel.Name = "sandboxProgramLabel";
            this.sandboxProgramLabel.Size = new System.Drawing.Size(135, 21);
            this.sandboxProgramLabel.TabIndex = 18;
            this.sandboxProgramLabel.Text = "Sandbox program";
            // 
            // donateLabel
            // 
            this.donateLabel.AutoSize = true;
            this.donateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.donateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.donateLabel.Location = new System.Drawing.Point(345, 373);
            this.donateLabel.Name = "donateLabel";
            this.donateLabel.Size = new System.Drawing.Size(60, 21);
            this.donateLabel.TabIndex = 36;
            this.donateLabel.Text = "Donate";
            this.donateLabel.Click += new System.EventHandler(this.donateLabel_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(84, 21);
            this.versionLabel.TabIndex = 37;
            this.versionLabel.Text = "<Version>";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.creditsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.creditsLabel.Location = new System.Drawing.Point(411, 373);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(59, 21);
            this.creditsLabel.TabIndex = 38;
            this.creditsLabel.Text = "Credits";
            this.creditsLabel.Click += new System.EventHandler(this.creditsLabel_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 500;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.donateLabel);
            this.Controls.Add(this.sandboxProgramLabel);
            this.Controls.Add(this.sandboxProgramCombo);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editAccountsButton);
            this.Controls.Add(this.accountsLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.launchGameButton);
            this.Controls.Add(this.launchSteamButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "SteamGamePanel2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button launchSteamButton;
        private Button launchGameButton;
        private ListView accountsList;
        private Label accountsLabel;
        private Button settingsButton;
        private Button editAccountsButton;
        private ColumnHeader usernameHeader;
        private ColumnHeader processIDHeader;
        private Button refreshButton;
        private ComboBox sandboxProgramCombo;
        private Label sandboxProgramLabel;
        private ColumnHeader statusHeader;
        private Label donateLabel;
        private Label versionLabel;
        private Label creditsLabel;
        private System.Windows.Forms.Timer refreshTimer;
    }
}