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
            this.launchSteamButton = new System.Windows.Forms.Button();
            this.launchGameButton = new System.Windows.Forms.Button();
            this.accountsList = new System.Windows.Forms.ListView();
            this.usernameHeader = new System.Windows.Forms.ColumnHeader();
            this.processIDHeader = new System.Windows.Forms.ColumnHeader();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.editAccountsButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.sandboxProgramCombo = new System.Windows.Forms.ComboBox();
            this.sandboxProgramLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // launchSteamButton
            // 
            this.launchSteamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchSteamButton.Location = new System.Drawing.Point(41, 300);
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
            this.launchGameButton.Location = new System.Drawing.Point(177, 300);
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
            this.processIDHeader});
            this.accountsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.accountsList.Location = new System.Drawing.Point(456, 84);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(262, 233);
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
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.Location = new System.Drawing.Point(456, 60);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(73, 21);
            this.accountsLabel.TabIndex = 4;
            this.accountsLabel.Text = "Accounts";
            // 
            // settingsButton
            // 
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(41, 356);
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
            this.editAccountsButton.Location = new System.Drawing.Point(456, 323);
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
            this.refreshButton.Location = new System.Drawing.Point(588, 323);
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
            this.sandboxProgramCombo.Location = new System.Drawing.Point(41, 265);
            this.sandboxProgramCombo.Name = "sandboxProgramCombo";
            this.sandboxProgramCombo.Size = new System.Drawing.Size(121, 29);
            this.sandboxProgramCombo.TabIndex = 17;
            // 
            // sandboxProgramLabel
            // 
            this.sandboxProgramLabel.AutoSize = true;
            this.sandboxProgramLabel.Location = new System.Drawing.Point(41, 241);
            this.sandboxProgramLabel.Name = "sandboxProgramLabel";
            this.sandboxProgramLabel.Size = new System.Drawing.Size(135, 21);
            this.sandboxProgramLabel.TabIndex = 18;
            this.sandboxProgramLabel.Text = "Sandbox program";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}