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
            this.maFilesPathLabel = new System.Windows.Forms.Label();
            this.maFilesPathText = new System.Windows.Forms.TextBox();
            this.sandboxieConfigurationPathText = new System.Windows.Forms.TextBox();
            this.sandboxieConfigurationPathLabel = new System.Windows.Forms.Label();
            this.monitorHeightLabel = new System.Windows.Forms.Label();
            this.monitorHeightText = new System.Windows.Forms.TextBox();
            this.monitorWidthLabel = new System.Windows.Forms.Label();
            this.monitorWidthText = new System.Windows.Forms.TextBox();
            this.generalLabel = new System.Windows.Forms.Label();
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
            this.inventoryRequestTimeText = new System.Windows.Forms.TextBox();
            this.inventoryRequestTimeLabel = new System.Windows.Forms.Label();
            this.scanUserInventoryCheck = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.generalLabel);
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
            // maFilesPathLabel
            // 
            this.maFilesPathLabel.AutoSize = true;
            this.maFilesPathLabel.Location = new System.Drawing.Point(80, 464);
            this.maFilesPathLabel.Name = "maFilesPathLabel";
            this.maFilesPathLabel.Size = new System.Drawing.Size(98, 21);
            this.maFilesPathLabel.TabIndex = 57;
            this.maFilesPathLabel.Text = "maFiles path";
            // 
            // maFilesPathText
            // 
            this.maFilesPathText.Location = new System.Drawing.Point(184, 456);
            this.maFilesPathText.Name = "maFilesPathText";
            this.maFilesPathText.Size = new System.Drawing.Size(171, 29);
            this.maFilesPathText.TabIndex = 56;
            // 
            // sandboxieConfigurationPathText
            // 
            this.sandboxieConfigurationPathText.Location = new System.Drawing.Point(184, 388);
            this.sandboxieConfigurationPathText.Name = "sandboxieConfigurationPathText";
            this.sandboxieConfigurationPathText.Size = new System.Drawing.Size(171, 29);
            this.sandboxieConfigurationPathText.TabIndex = 55;
            // 
            // sandboxieConfigurationPathLabel
            // 
            this.sandboxieConfigurationPathLabel.AutoSize = true;
            this.sandboxieConfigurationPathLabel.Location = new System.Drawing.Point(37, 391);
            this.sandboxieConfigurationPathLabel.Name = "sandboxieConfigurationPathLabel";
            this.sandboxieConfigurationPathLabel.Size = new System.Drawing.Size(141, 21);
            this.sandboxieConfigurationPathLabel.TabIndex = 54;
            this.sandboxieConfigurationPathLabel.Text = "Configuration path";
            // 
            // monitorHeightLabel
            // 
            this.monitorHeightLabel.AutoSize = true;
            this.monitorHeightLabel.Location = new System.Drawing.Point(64, 424);
            this.monitorHeightLabel.Name = "monitorHeightLabel";
            this.monitorHeightLabel.Size = new System.Drawing.Size(114, 21);
            this.monitorHeightLabel.TabIndex = 53;
            this.monitorHeightLabel.Text = "Monitor height";
            // 
            // monitorHeightText
            // 
            this.monitorHeightText.Location = new System.Drawing.Point(184, 421);
            this.monitorHeightText.Name = "monitorHeightText";
            this.monitorHeightText.Size = new System.Drawing.Size(171, 29);
            this.monitorHeightText.TabIndex = 52;
            // 
            // monitorWidthLabel
            // 
            this.monitorWidthLabel.AutoSize = true;
            this.monitorWidthLabel.Location = new System.Drawing.Point(69, 447);
            this.monitorWidthLabel.Name = "monitorWidthLabel";
            this.monitorWidthLabel.Size = new System.Drawing.Size(109, 21);
            this.monitorWidthLabel.TabIndex = 51;
            this.monitorWidthLabel.Text = "Monitor width";
            // 
            // monitorWidthText
            // 
            this.monitorWidthText.Location = new System.Drawing.Point(184, 444);
            this.monitorWidthText.Name = "monitorWidthText";
            this.monitorWidthText.Size = new System.Drawing.Size(171, 29);
            this.monitorWidthText.TabIndex = 50;
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.Location = new System.Drawing.Point(184, 420);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(64, 21);
            this.generalLabel.TabIndex = 49;
            this.generalLabel.Text = "General";
            // 
            // gamePortLabel
            // 
            this.gamePortLabel.AutoSize = true;
            this.gamePortLabel.Location = new System.Drawing.Point(142, 300);
            this.gamePortLabel.Name = "gamePortLabel";
            this.gamePortLabel.Size = new System.Drawing.Size(38, 21);
            this.gamePortLabel.TabIndex = 48;
            this.gamePortLabel.Text = "Port";
            // 
            // gamePortText
            // 
            this.gamePortText.Location = new System.Drawing.Point(186, 297);
            this.gamePortText.Name = "gamePortText";
            this.gamePortText.Size = new System.Drawing.Size(171, 29);
            this.gamePortText.TabIndex = 47;
            // 
            // gameIPLabel
            // 
            this.gameIPLabel.AutoSize = true;
            this.gameIPLabel.Location = new System.Drawing.Point(157, 262);
            this.gameIPLabel.Name = "gameIPLabel";
            this.gameIPLabel.Size = new System.Drawing.Size(23, 21);
            this.gameIPLabel.TabIndex = 46;
            this.gameIPLabel.Text = "IP";
            // 
            // gameIPText
            // 
            this.gameIPText.Location = new System.Drawing.Point(186, 262);
            this.gameIPText.Name = "gameIPText";
            this.gameIPText.Size = new System.Drawing.Size(171, 29);
            this.gameIPText.TabIndex = 45;
            // 
            // gameHeightLabel
            // 
            this.gameHeightLabel.AutoSize = true;
            this.gameHeightLabel.Location = new System.Drawing.Point(124, 230);
            this.gameHeightLabel.Name = "gameHeightLabel";
            this.gameHeightLabel.Size = new System.Drawing.Size(56, 21);
            this.gameHeightLabel.TabIndex = 44;
            this.gameHeightLabel.Text = "Height";
            // 
            // gameHeightText
            // 
            this.gameHeightText.Location = new System.Drawing.Point(186, 227);
            this.gameHeightText.Name = "gameHeightText";
            this.gameHeightText.Size = new System.Drawing.Size(171, 29);
            this.gameHeightText.TabIndex = 43;
            // 
            // gameWidthLabel
            // 
            this.gameWidthLabel.AutoSize = true;
            this.gameWidthLabel.Location = new System.Drawing.Point(128, 195);
            this.gameWidthLabel.Name = "gameWidthLabel";
            this.gameWidthLabel.Size = new System.Drawing.Size(52, 21);
            this.gameWidthLabel.TabIndex = 42;
            this.gameWidthLabel.Text = "Width";
            // 
            // gameWidthText
            // 
            this.gameWidthText.Location = new System.Drawing.Point(186, 192);
            this.gameWidthText.Name = "gameWidthText";
            this.gameWidthText.Size = new System.Drawing.Size(171, 29);
            this.gameWidthText.TabIndex = 41;
            // 
            // gameIDLabel
            // 
            this.gameIDLabel.AutoSize = true;
            this.gameIDLabel.Location = new System.Drawing.Point(110, 160);
            this.gameIDLabel.Name = "gameIDLabel";
            this.gameIDLabel.Size = new System.Drawing.Size(70, 21);
            this.gameIDLabel.TabIndex = 40;
            this.gameIDLabel.Text = "Game ID";
            // 
            // gameIDText
            // 
            this.gameIDText.Location = new System.Drawing.Point(186, 157);
            this.gameIDText.Name = "gameIDText";
            this.gameIDText.Size = new System.Drawing.Size(171, 29);
            this.gameIDText.TabIndex = 39;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(184, 133);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(51, 21);
            this.gameLabel.TabIndex = 38;
            this.gameLabel.Text = "Game";
            // 
            // sandboxiePathText
            // 
            this.sandboxiePathText.Location = new System.Drawing.Point(184, 353);
            this.sandboxiePathText.Name = "sandboxiePathText";
            this.sandboxiePathText.Size = new System.Drawing.Size(171, 29);
            this.sandboxiePathText.TabIndex = 37;
            // 
            // steamPathText
            // 
            this.steamPathText.Location = new System.Drawing.Point(184, 28);
            this.steamPathText.Name = "steamPathText";
            this.steamPathText.Size = new System.Drawing.Size(171, 29);
            this.steamPathText.TabIndex = 36;
            // 
            // sandboxiePathLabel
            // 
            this.sandboxiePathLabel.AutoSize = true;
            this.sandboxiePathLabel.Location = new System.Drawing.Point(138, 356);
            this.sandboxiePathLabel.Name = "sandboxiePathLabel";
            this.sandboxiePathLabel.Size = new System.Drawing.Size(40, 21);
            this.sandboxiePathLabel.TabIndex = 35;
            this.sandboxiePathLabel.Text = "Path";
            // 
            // sandboxieLabel
            // 
            this.sandboxieLabel.AutoSize = true;
            this.sandboxieLabel.Location = new System.Drawing.Point(184, 329);
            this.sandboxieLabel.Name = "sandboxieLabel";
            this.sandboxieLabel.Size = new System.Drawing.Size(82, 21);
            this.sandboxieLabel.TabIndex = 34;
            this.sandboxieLabel.Text = "Sandboxie";
            // 
            // steamPathLabel
            // 
            this.steamPathLabel.AutoSize = true;
            this.steamPathLabel.Location = new System.Drawing.Point(138, 31);
            this.steamPathLabel.Name = "steamPathLabel";
            this.steamPathLabel.Size = new System.Drawing.Size(40, 21);
            this.steamPathLabel.TabIndex = 33;
            this.steamPathLabel.Text = "Path";
            // 
            // steamLabel
            // 
            this.steamLabel.AutoSize = true;
            this.steamLabel.Location = new System.Drawing.Point(184, 4);
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
            // inventoryRequestTimeText
            // 
            this.inventoryRequestTimeText.Location = new System.Drawing.Point(184, 63);
            this.inventoryRequestTimeText.Name = "inventoryRequestTimeText";
            this.inventoryRequestTimeText.Size = new System.Drawing.Size(171, 29);
            this.inventoryRequestTimeText.TabIndex = 59;
            // 
            // inventoryRequestTimeLabel
            // 
            this.inventoryRequestTimeLabel.AutoSize = true;
            this.inventoryRequestTimeLabel.Location = new System.Drawing.Point(11, 66);
            this.inventoryRequestTimeLabel.Name = "inventoryRequestTimeLabel";
            this.inventoryRequestTimeLabel.Size = new System.Drawing.Size(167, 21);
            this.inventoryRequestTimeLabel.TabIndex = 58;
            this.inventoryRequestTimeLabel.Text = "Inventory request time";
            // 
            // scanUserInventoryCheck
            // 
            this.scanUserInventoryCheck.AutoSize = true;
            this.scanUserInventoryCheck.Location = new System.Drawing.Point(184, 98);
            this.scanUserInventoryCheck.Name = "scanUserInventoryCheck";
            this.scanUserInventoryCheck.Size = new System.Drawing.Size(166, 25);
            this.scanUserInventoryCheck.TabIndex = 60;
            this.scanUserInventoryCheck.Text = "Scan user inventory";
            this.scanUserInventoryCheck.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private Label generalLabel;
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
    }
}