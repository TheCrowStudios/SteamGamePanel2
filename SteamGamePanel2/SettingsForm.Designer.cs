namespace SteamGamePanelUI
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputDelayLabel = new System.Windows.Forms.Label();
            this.inputDelayText = new System.Windows.Forms.TextBox();
            this.launchSpanLabel = new System.Windows.Forms.Label();
            this.launchSpanText = new System.Windows.Forms.TextBox();
            this.accountDelayLabel = new System.Windows.Forms.Label();
            this.accountDelayText = new System.Windows.Forms.TextBox();
            this.presetCombo = new System.Windows.Forms.ComboBox();
            this.sgpLabel = new System.Windows.Forms.Label();
            this.scanUserInventoryCheck = new System.Windows.Forms.CheckBox();
            this.inventoryRequestTimeText = new System.Windows.Forms.TextBox();
            this.inventoryRequestTimeLabel = new System.Windows.Forms.Label();
            this.maFilesPathLabel = new System.Windows.Forms.Label();
            this.maFilesPathText = new System.Windows.Forms.TextBox();
            this.sandboxieConfigurationPathText = new System.Windows.Forms.TextBox();
            this.sandboxieConfigurationPathLabel = new System.Windows.Forms.Label();
            this.monitorHeightLabel = new System.Windows.Forms.Label();
            this.monitorHeightText = new System.Windows.Forms.TextBox();
            this.monitorWidthLabel = new System.Windows.Forms.Label();
            this.monitorWidthText = new System.Windows.Forms.TextBox();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.gamePortLabel = new System.Windows.Forms.Label();
            this.gamePortText = new System.Windows.Forms.TextBox();
            this.gameIPLabel = new System.Windows.Forms.Label();
            this.gameIPText = new System.Windows.Forms.TextBox();
            this.gameHeightLabel = new System.Windows.Forms.Label();
            this.gameHeightText = new System.Windows.Forms.TextBox();
            this.gameWidthLabel = new System.Windows.Forms.Label();
            this.gameWidthText = new System.Windows.Forms.TextBox();
            this.gameIDLabel = new System.Windows.Forms.Label();
            this.gameIDText = new System.Windows.Forms.TextBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.sandboxiePathText = new System.Windows.Forms.TextBox();
            this.steamPathText = new System.Windows.Forms.TextBox();
            this.sandboxiePathLabel = new System.Windows.Forms.Label();
            this.sandboxieLabel = new System.Windows.Forms.Label();
            this.steamPathLabel = new System.Windows.Forms.Label();
            this.steamLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.presetLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(265, 385);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 50);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(401, 385);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 50);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.presetLabel);
            this.panel1.Controls.Add(this.inputDelayLabel);
            this.panel1.Controls.Add(this.inputDelayText);
            this.panel1.Controls.Add(this.launchSpanLabel);
            this.panel1.Controls.Add(this.launchSpanText);
            this.panel1.Controls.Add(this.accountDelayLabel);
            this.panel1.Controls.Add(this.accountDelayText);
            this.panel1.Controls.Add(this.presetCombo);
            this.panel1.Controls.Add(this.sgpLabel);
            this.panel1.Controls.Add(this.scanUserInventoryCheck);
            this.panel1.Controls.Add(this.inventoryRequestTimeText);
            this.panel1.Controls.Add(this.inventoryRequestTimeLabel);
            this.panel1.Controls.Add(this.maFilesPathLabel);
            this.panel1.Controls.Add(this.maFilesPathText);
            this.panel1.Controls.Add(this.sandboxieConfigurationPathText);
            this.panel1.Controls.Add(this.sandboxieConfigurationPathLabel);
            this.panel1.Controls.Add(this.monitorHeightLabel);
            this.panel1.Controls.Add(this.monitorHeightText);
            this.panel1.Controls.Add(this.monitorWidthLabel);
            this.panel1.Controls.Add(this.monitorWidthText);
            this.panel1.Controls.Add(this.accountsLabel);
            this.panel1.Controls.Add(this.gamePortLabel);
            this.panel1.Controls.Add(this.gamePortText);
            this.panel1.Controls.Add(this.gameIPLabel);
            this.panel1.Controls.Add(this.gameIPText);
            this.panel1.Controls.Add(this.gameHeightLabel);
            this.panel1.Controls.Add(this.gameHeightText);
            this.panel1.Controls.Add(this.gameWidthLabel);
            this.panel1.Controls.Add(this.gameWidthText);
            this.panel1.Controls.Add(this.gameIDLabel);
            this.panel1.Controls.Add(this.gameIDText);
            this.panel1.Controls.Add(this.gameLabel);
            this.panel1.Controls.Add(this.sandboxiePathText);
            this.panel1.Controls.Add(this.steamPathText);
            this.panel1.Controls.Add(this.sandboxiePathLabel);
            this.panel1.Controls.Add(this.sandboxieLabel);
            this.panel1.Controls.Add(this.steamPathLabel);
            this.panel1.Controls.Add(this.steamLabel);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 318);
            this.panel1.TabIndex = 32;
            // 
            // inputDelayLabel
            // 
            this.inputDelayLabel.AutoSize = true;
            this.inputDelayLabel.Location = new System.Drawing.Point(56, 154);
            this.inputDelayLabel.Name = "inputDelayLabel";
            this.inputDelayLabel.Size = new System.Drawing.Size(117, 21);
            this.inputDelayLabel.TabIndex = 68;
            this.inputDelayLabel.Text = "Text input delay";
            // 
            // inputDelayText
            // 
            this.inputDelayText.Location = new System.Drawing.Point(179, 151);
            this.inputDelayText.Name = "inputDelayText";
            this.inputDelayText.Size = new System.Drawing.Size(171, 29);
            this.inputDelayText.TabIndex = 67;
            // 
            // launchSpanLabel
            // 
            this.launchSpanLabel.AutoSize = true;
            this.launchSpanLabel.Location = new System.Drawing.Point(23, 119);
            this.launchSpanLabel.Name = "launchSpanLabel";
            this.launchSpanLabel.Size = new System.Drawing.Size(150, 21);
            this.launchSpanLabel.TabIndex = 66;
            this.launchSpanLabel.Text = "Process launch span";
            // 
            // launchSpanText
            // 
            this.launchSpanText.Location = new System.Drawing.Point(179, 116);
            this.launchSpanText.Name = "launchSpanText";
            this.launchSpanText.Size = new System.Drawing.Size(171, 29);
            this.launchSpanText.TabIndex = 65;
            // 
            // accountDelayLabel
            // 
            this.accountDelayLabel.AutoSize = true;
            this.accountDelayLabel.Location = new System.Drawing.Point(66, 84);
            this.accountDelayLabel.Name = "accountDelayLabel";
            this.accountDelayLabel.Size = new System.Drawing.Size(107, 21);
            this.accountDelayLabel.TabIndex = 64;
            this.accountDelayLabel.Text = "Account delay";
            // 
            // accountDelayText
            // 
            this.accountDelayText.Location = new System.Drawing.Point(179, 81);
            this.accountDelayText.Name = "accountDelayText";
            this.accountDelayText.Size = new System.Drawing.Size(171, 29);
            this.accountDelayText.TabIndex = 63;
            // 
            // presetCombo
            // 
            this.presetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetCombo.FormattingEnabled = true;
            this.presetCombo.Location = new System.Drawing.Point(179, 46);
            this.presetCombo.Name = "presetCombo";
            this.presetCombo.Size = new System.Drawing.Size(121, 29);
            this.presetCombo.TabIndex = 62;
            this.presetCombo.SelectedIndexChanged += new System.EventHandler(this.presetCombo_SelectedIndexChanged);
            // 
            // sgpLabel
            // 
            this.sgpLabel.AutoSize = true;
            this.sgpLabel.Location = new System.Drawing.Point(179, 22);
            this.sgpLabel.Name = "sgpLabel";
            this.sgpLabel.Size = new System.Drawing.Size(39, 21);
            this.sgpLabel.TabIndex = 61;
            this.sgpLabel.Text = "SGP";
            // 
            // scanUserInventoryCheck
            // 
            this.scanUserInventoryCheck.AutoSize = true;
            this.scanUserInventoryCheck.Location = new System.Drawing.Point(177, 276);
            this.scanUserInventoryCheck.Name = "scanUserInventoryCheck";
            this.scanUserInventoryCheck.Size = new System.Drawing.Size(166, 25);
            this.scanUserInventoryCheck.TabIndex = 60;
            this.scanUserInventoryCheck.Text = "Scan user inventory";
            this.scanUserInventoryCheck.UseVisualStyleBackColor = true;
            // 
            // inventoryRequestTimeText
            // 
            this.inventoryRequestTimeText.Location = new System.Drawing.Point(179, 241);
            this.inventoryRequestTimeText.Name = "inventoryRequestTimeText";
            this.inventoryRequestTimeText.Size = new System.Drawing.Size(171, 29);
            this.inventoryRequestTimeText.TabIndex = 59;
            // 
            // inventoryRequestTimeLabel
            // 
            this.inventoryRequestTimeLabel.AutoSize = true;
            this.inventoryRequestTimeLabel.Location = new System.Drawing.Point(6, 244);
            this.inventoryRequestTimeLabel.Name = "inventoryRequestTimeLabel";
            this.inventoryRequestTimeLabel.Size = new System.Drawing.Size(167, 21);
            this.inventoryRequestTimeLabel.TabIndex = 58;
            this.inventoryRequestTimeLabel.Text = "Inventory request time";
            // 
            // maFilesPathLabel
            // 
            this.maFilesPathLabel.AutoSize = true;
            this.maFilesPathLabel.Location = new System.Drawing.Point(75, 212);
            this.maFilesPathLabel.Name = "maFilesPathLabel";
            this.maFilesPathLabel.Size = new System.Drawing.Size(98, 21);
            this.maFilesPathLabel.TabIndex = 57;
            this.maFilesPathLabel.Text = "maFiles path";
            // 
            // maFilesPathText
            // 
            this.maFilesPathText.Location = new System.Drawing.Point(179, 209);
            this.maFilesPathText.Name = "maFilesPathText";
            this.maFilesPathText.Size = new System.Drawing.Size(171, 29);
            this.maFilesPathText.TabIndex = 56;
            // 
            // sandboxieConfigurationPathText
            // 
            this.sandboxieConfigurationPathText.Location = new System.Drawing.Point(179, 568);
            this.sandboxieConfigurationPathText.Name = "sandboxieConfigurationPathText";
            this.sandboxieConfigurationPathText.Size = new System.Drawing.Size(171, 29);
            this.sandboxieConfigurationPathText.TabIndex = 55;
            // 
            // sandboxieConfigurationPathLabel
            // 
            this.sandboxieConfigurationPathLabel.AutoSize = true;
            this.sandboxieConfigurationPathLabel.Location = new System.Drawing.Point(32, 571);
            this.sandboxieConfigurationPathLabel.Name = "sandboxieConfigurationPathLabel";
            this.sandboxieConfigurationPathLabel.Size = new System.Drawing.Size(141, 21);
            this.sandboxieConfigurationPathLabel.TabIndex = 54;
            this.sandboxieConfigurationPathLabel.Text = "Configuration path";
            // 
            // monitorHeightLabel
            // 
            this.monitorHeightLabel.AutoSize = true;
            this.monitorHeightLabel.Location = new System.Drawing.Point(59, 606);
            this.monitorHeightLabel.Name = "monitorHeightLabel";
            this.monitorHeightLabel.Size = new System.Drawing.Size(114, 21);
            this.monitorHeightLabel.TabIndex = 53;
            this.monitorHeightLabel.Text = "Monitor height";
            // 
            // monitorHeightText
            // 
            this.monitorHeightText.Location = new System.Drawing.Point(179, 603);
            this.monitorHeightText.Name = "monitorHeightText";
            this.monitorHeightText.Size = new System.Drawing.Size(171, 29);
            this.monitorHeightText.TabIndex = 52;
            // 
            // monitorWidthLabel
            // 
            this.monitorWidthLabel.AutoSize = true;
            this.monitorWidthLabel.Location = new System.Drawing.Point(64, 641);
            this.monitorWidthLabel.Name = "monitorWidthLabel";
            this.monitorWidthLabel.Size = new System.Drawing.Size(109, 21);
            this.monitorWidthLabel.TabIndex = 51;
            this.monitorWidthLabel.Text = "Monitor width";
            // 
            // monitorWidthText
            // 
            this.monitorWidthText.Location = new System.Drawing.Point(179, 638);
            this.monitorWidthText.Name = "monitorWidthText";
            this.monitorWidthText.Size = new System.Drawing.Size(171, 29);
            this.monitorWidthText.TabIndex = 50;
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.Location = new System.Drawing.Point(179, 185);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(73, 21);
            this.accountsLabel.TabIndex = 49;
            this.accountsLabel.Text = "Accounts";
            // 
            // gamePortLabel
            // 
            this.gamePortLabel.AutoSize = true;
            this.gamePortLabel.Location = new System.Drawing.Point(135, 474);
            this.gamePortLabel.Name = "gamePortLabel";
            this.gamePortLabel.Size = new System.Drawing.Size(38, 21);
            this.gamePortLabel.TabIndex = 48;
            this.gamePortLabel.Text = "Port";
            // 
            // gamePortText
            // 
            this.gamePortText.Location = new System.Drawing.Point(179, 471);
            this.gamePortText.Name = "gamePortText";
            this.gamePortText.Size = new System.Drawing.Size(171, 29);
            this.gamePortText.TabIndex = 47;
            // 
            // gameIPLabel
            // 
            this.gameIPLabel.AutoSize = true;
            this.gameIPLabel.Location = new System.Drawing.Point(150, 436);
            this.gameIPLabel.Name = "gameIPLabel";
            this.gameIPLabel.Size = new System.Drawing.Size(23, 21);
            this.gameIPLabel.TabIndex = 46;
            this.gameIPLabel.Text = "IP";
            // 
            // gameIPText
            // 
            this.gameIPText.Location = new System.Drawing.Point(179, 436);
            this.gameIPText.Name = "gameIPText";
            this.gameIPText.Size = new System.Drawing.Size(171, 29);
            this.gameIPText.TabIndex = 45;
            // 
            // gameHeightLabel
            // 
            this.gameHeightLabel.AutoSize = true;
            this.gameHeightLabel.Location = new System.Drawing.Point(117, 404);
            this.gameHeightLabel.Name = "gameHeightLabel";
            this.gameHeightLabel.Size = new System.Drawing.Size(56, 21);
            this.gameHeightLabel.TabIndex = 44;
            this.gameHeightLabel.Text = "Height";
            // 
            // gameHeightText
            // 
            this.gameHeightText.Location = new System.Drawing.Point(179, 401);
            this.gameHeightText.Name = "gameHeightText";
            this.gameHeightText.Size = new System.Drawing.Size(171, 29);
            this.gameHeightText.TabIndex = 43;
            // 
            // gameWidthLabel
            // 
            this.gameWidthLabel.AutoSize = true;
            this.gameWidthLabel.Location = new System.Drawing.Point(121, 369);
            this.gameWidthLabel.Name = "gameWidthLabel";
            this.gameWidthLabel.Size = new System.Drawing.Size(52, 21);
            this.gameWidthLabel.TabIndex = 42;
            this.gameWidthLabel.Text = "Width";
            // 
            // gameWidthText
            // 
            this.gameWidthText.Location = new System.Drawing.Point(179, 366);
            this.gameWidthText.Name = "gameWidthText";
            this.gameWidthText.Size = new System.Drawing.Size(171, 29);
            this.gameWidthText.TabIndex = 41;
            // 
            // gameIDLabel
            // 
            this.gameIDLabel.AutoSize = true;
            this.gameIDLabel.Location = new System.Drawing.Point(103, 334);
            this.gameIDLabel.Name = "gameIDLabel";
            this.gameIDLabel.Size = new System.Drawing.Size(70, 21);
            this.gameIDLabel.TabIndex = 40;
            this.gameIDLabel.Text = "Game ID";
            // 
            // gameIDText
            // 
            this.gameIDText.Location = new System.Drawing.Point(179, 331);
            this.gameIDText.Name = "gameIDText";
            this.gameIDText.Size = new System.Drawing.Size(171, 29);
            this.gameIDText.TabIndex = 39;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(177, 307);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(51, 21);
            this.gameLabel.TabIndex = 38;
            this.gameLabel.Text = "Game";
            // 
            // sandboxiePathText
            // 
            this.sandboxiePathText.Location = new System.Drawing.Point(179, 533);
            this.sandboxiePathText.Name = "sandboxiePathText";
            this.sandboxiePathText.Size = new System.Drawing.Size(171, 29);
            this.sandboxiePathText.TabIndex = 37;
            // 
            // steamPathText
            // 
            this.steamPathText.Location = new System.Drawing.Point(184, -252);
            this.steamPathText.Name = "steamPathText";
            this.steamPathText.Size = new System.Drawing.Size(171, 29);
            this.steamPathText.TabIndex = 36;
            // 
            // sandboxiePathLabel
            // 
            this.sandboxiePathLabel.AutoSize = true;
            this.sandboxiePathLabel.Location = new System.Drawing.Point(133, 536);
            this.sandboxiePathLabel.Name = "sandboxiePathLabel";
            this.sandboxiePathLabel.Size = new System.Drawing.Size(40, 21);
            this.sandboxiePathLabel.TabIndex = 35;
            this.sandboxiePathLabel.Text = "Path";
            // 
            // sandboxieLabel
            // 
            this.sandboxieLabel.AutoSize = true;
            this.sandboxieLabel.Location = new System.Drawing.Point(179, 509);
            this.sandboxieLabel.Name = "sandboxieLabel";
            this.sandboxieLabel.Size = new System.Drawing.Size(82, 21);
            this.sandboxieLabel.TabIndex = 34;
            this.sandboxieLabel.Text = "Sandboxie";
            // 
            // steamPathLabel
            // 
            this.steamPathLabel.AutoSize = true;
            this.steamPathLabel.Location = new System.Drawing.Point(138, -249);
            this.steamPathLabel.Name = "steamPathLabel";
            this.steamPathLabel.Size = new System.Drawing.Size(40, 21);
            this.steamPathLabel.TabIndex = 33;
            this.steamPathLabel.Text = "Path";
            // 
            // steamLabel
            // 
            this.steamLabel.AutoSize = true;
            this.steamLabel.Location = new System.Drawing.Point(184, -276);
            this.steamLabel.Name = "steamLabel";
            this.steamLabel.Size = new System.Drawing.Size(53, 21);
            this.steamLabel.TabIndex = 32;
            this.steamLabel.Text = "Steam";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsLabel.Location = new System.Drawing.Point(357, 32);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(87, 30);
            this.settingsLabel.TabIndex = 27;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(84, 21);
            this.versionLabel.TabIndex = 38;
            this.versionLabel.Text = "<Version>";
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Location = new System.Drawing.Point(537, 382);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(75, 21);
            this.notifyLabel.TabIndex = 39;
            this.notifyLabel.Text = "<Notify>";
            // 
            // presetLabel
            // 
            this.presetLabel.AutoSize = true;
            this.presetLabel.Location = new System.Drawing.Point(120, 49);
            this.presetLabel.Name = "presetLabel";
            this.presetLabel.Size = new System.Drawing.Size(53, 21);
            this.presetLabel.TabIndex = 69;
            this.presetLabel.Text = "Preset";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "SteamGamePanel2 settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveButton;
        private Button cancelButton;
        private Panel panel1;
        private Label maFilesPathLabel;
        private TextBox maFilesPathText;
        private TextBox sandboxieConfigurationPathText;
        private Label sandboxieConfigurationPathLabel;
        private Label monitorHeightLabel;
        private TextBox monitorHeightText;
        private Label monitorWidthLabel;
        private TextBox monitorWidthText;
        private Label accountsLabel;
        private Label gamePortLabel;
        private TextBox gamePortText;
        private Label gameIPLabel;
        private TextBox gameIPText;
        private Label gameHeightLabel;
        private TextBox gameHeightText;
        private Label gameWidthLabel;
        private TextBox gameWidthText;
        private Label gameIDLabel;
        private TextBox gameIDText;
        private Label gameLabel;
        private TextBox sandboxiePathText;
        private TextBox steamPathText;
        private Label sandboxiePathLabel;
        private Label sandboxieLabel;
        private Label steamPathLabel;
        private Label steamLabel;
        private Label settingsLabel;
        private TextBox inventoryRequestTimeText;
        private Label inventoryRequestTimeLabel;
        private CheckBox scanUserInventoryCheck;
        private Label versionLabel;
        private Label notifyLabel;
        private Label sgpLabel;
        private ComboBox presetCombo;
        private Label launchSpanLabel;
        private TextBox launchSpanText;
        private Label accountDelayLabel;
        private TextBox accountDelayText;
        private Label inputDelayLabel;
        private TextBox inputDelayText;
        private Label presetLabel;
    }
}