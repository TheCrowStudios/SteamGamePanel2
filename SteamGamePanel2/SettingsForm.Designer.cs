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
            this.steamLabel = new System.Windows.Forms.Label();
            this.steamPathLabel = new System.Windows.Forms.Label();
            this.sandboxieLabel = new System.Windows.Forms.Label();
            this.sandboxiePathLabel = new System.Windows.Forms.Label();
            this.steamPathText = new System.Windows.Forms.TextBox();
            this.sandboxiePathText = new System.Windows.Forms.TextBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.gameIDText = new System.Windows.Forms.TextBox();
            this.gameIDLabel = new System.Windows.Forms.Label();
            this.gameWidthLabel = new System.Windows.Forms.Label();
            this.gameWidthText = new System.Windows.Forms.TextBox();
            this.gameHeightLabel = new System.Windows.Forms.Label();
            this.gameHeightText = new System.Windows.Forms.TextBox();
            this.gameIPLabel = new System.Windows.Forms.Label();
            this.gameIPText = new System.Windows.Forms.TextBox();
            this.gamePortLabel = new System.Windows.Forms.Label();
            this.gamePortText = new System.Windows.Forms.TextBox();
            this.generalLabel = new System.Windows.Forms.Label();
            this.monitorWidthLabel = new System.Windows.Forms.Label();
            this.monitorWidthText = new System.Windows.Forms.TextBox();
            this.monitorHeightLabel = new System.Windows.Forms.Label();
            this.monitorHeightText = new System.Windows.Forms.TextBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.sandboxieConfigurationPathText = new System.Windows.Forms.TextBox();
            this.sandboxieConfigurationPathLabel = new System.Windows.Forms.Label();
            this.maFilesPathLabel = new System.Windows.Forms.Label();
            this.maFilesPathText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(265, 333);
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
            this.cancelButton.Location = new System.Drawing.Point(401, 333);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 50);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // steamLabel
            // 
            this.steamLabel.AutoSize = true;
            this.steamLabel.Location = new System.Drawing.Point(62, 76);
            this.steamLabel.Name = "steamLabel";
            this.steamLabel.Size = new System.Drawing.Size(53, 21);
            this.steamLabel.TabIndex = 5;
            this.steamLabel.Text = "Steam";
            // 
            // steamPathLabel
            // 
            this.steamPathLabel.AutoSize = true;
            this.steamPathLabel.Location = new System.Drawing.Point(16, 103);
            this.steamPathLabel.Name = "steamPathLabel";
            this.steamPathLabel.Size = new System.Drawing.Size(40, 21);
            this.steamPathLabel.TabIndex = 6;
            this.steamPathLabel.Text = "Path";
            // 
            // sandboxieLabel
            // 
            this.sandboxieLabel.AutoSize = true;
            this.sandboxieLabel.Location = new System.Drawing.Point(285, 76);
            this.sandboxieLabel.Name = "sandboxieLabel";
            this.sandboxieLabel.Size = new System.Drawing.Size(82, 21);
            this.sandboxieLabel.TabIndex = 7;
            this.sandboxieLabel.Text = "Sandboxie";
            // 
            // sandboxiePathLabel
            // 
            this.sandboxiePathLabel.AutoSize = true;
            this.sandboxiePathLabel.Location = new System.Drawing.Point(239, 103);
            this.sandboxiePathLabel.Name = "sandboxiePathLabel";
            this.sandboxiePathLabel.Size = new System.Drawing.Size(40, 21);
            this.sandboxiePathLabel.TabIndex = 8;
            this.sandboxiePathLabel.Text = "Path";
            // 
            // steamPathText
            // 
            this.steamPathText.Location = new System.Drawing.Point(62, 100);
            this.steamPathText.Name = "steamPathText";
            this.steamPathText.Size = new System.Drawing.Size(171, 29);
            this.steamPathText.TabIndex = 9;
            // 
            // sandboxiePathText
            // 
            this.sandboxiePathText.Location = new System.Drawing.Point(285, 100);
            this.sandboxiePathText.Name = "sandboxiePathText";
            this.sandboxiePathText.Size = new System.Drawing.Size(171, 29);
            this.sandboxiePathText.TabIndex = 10;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(551, 67);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(51, 21);
            this.gameLabel.TabIndex = 11;
            this.gameLabel.Text = "Game";
            // 
            // gameIDText
            // 
            this.gameIDText.Location = new System.Drawing.Point(551, 100);
            this.gameIDText.Name = "gameIDText";
            this.gameIDText.Size = new System.Drawing.Size(171, 29);
            this.gameIDText.TabIndex = 12;
            // 
            // gameIDLabel
            // 
            this.gameIDLabel.AutoSize = true;
            this.gameIDLabel.Location = new System.Drawing.Point(475, 103);
            this.gameIDLabel.Name = "gameIDLabel";
            this.gameIDLabel.Size = new System.Drawing.Size(70, 21);
            this.gameIDLabel.TabIndex = 13;
            this.gameIDLabel.Text = "Game ID";
            // 
            // gameWidthLabel
            // 
            this.gameWidthLabel.AutoSize = true;
            this.gameWidthLabel.Location = new System.Drawing.Point(493, 138);
            this.gameWidthLabel.Name = "gameWidthLabel";
            this.gameWidthLabel.Size = new System.Drawing.Size(52, 21);
            this.gameWidthLabel.TabIndex = 15;
            this.gameWidthLabel.Text = "Width";
            // 
            // gameWidthText
            // 
            this.gameWidthText.Location = new System.Drawing.Point(551, 135);
            this.gameWidthText.Name = "gameWidthText";
            this.gameWidthText.Size = new System.Drawing.Size(171, 29);
            this.gameWidthText.TabIndex = 14;
            // 
            // gameHeightLabel
            // 
            this.gameHeightLabel.AutoSize = true;
            this.gameHeightLabel.Location = new System.Drawing.Point(489, 173);
            this.gameHeightLabel.Name = "gameHeightLabel";
            this.gameHeightLabel.Size = new System.Drawing.Size(56, 21);
            this.gameHeightLabel.TabIndex = 17;
            this.gameHeightLabel.Text = "Height";
            // 
            // gameHeightText
            // 
            this.gameHeightText.Location = new System.Drawing.Point(551, 170);
            this.gameHeightText.Name = "gameHeightText";
            this.gameHeightText.Size = new System.Drawing.Size(171, 29);
            this.gameHeightText.TabIndex = 16;
            // 
            // gameIPLabel
            // 
            this.gameIPLabel.AutoSize = true;
            this.gameIPLabel.Location = new System.Drawing.Point(522, 205);
            this.gameIPLabel.Name = "gameIPLabel";
            this.gameIPLabel.Size = new System.Drawing.Size(23, 21);
            this.gameIPLabel.TabIndex = 19;
            this.gameIPLabel.Text = "IP";
            // 
            // gameIPText
            // 
            this.gameIPText.Location = new System.Drawing.Point(551, 205);
            this.gameIPText.Name = "gameIPText";
            this.gameIPText.Size = new System.Drawing.Size(171, 29);
            this.gameIPText.TabIndex = 18;
            // 
            // gamePortLabel
            // 
            this.gamePortLabel.AutoSize = true;
            this.gamePortLabel.Location = new System.Drawing.Point(507, 243);
            this.gamePortLabel.Name = "gamePortLabel";
            this.gamePortLabel.Size = new System.Drawing.Size(38, 21);
            this.gamePortLabel.TabIndex = 21;
            this.gamePortLabel.Text = "Port";
            // 
            // gamePortText
            // 
            this.gamePortText.Location = new System.Drawing.Point(551, 240);
            this.gamePortText.Name = "gamePortText";
            this.gamePortText.Size = new System.Drawing.Size(171, 29);
            this.gamePortText.TabIndex = 20;
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.Location = new System.Drawing.Point(143, 189);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(64, 21);
            this.generalLabel.TabIndex = 22;
            this.generalLabel.Text = "General";
            // 
            // monitorWidthLabel
            // 
            this.monitorWidthLabel.AutoSize = true;
            this.monitorWidthLabel.Location = new System.Drawing.Point(28, 216);
            this.monitorWidthLabel.Name = "monitorWidthLabel";
            this.monitorWidthLabel.Size = new System.Drawing.Size(109, 21);
            this.monitorWidthLabel.TabIndex = 24;
            this.monitorWidthLabel.Text = "Monitor width";
            // 
            // monitorWidthText
            // 
            this.monitorWidthText.Location = new System.Drawing.Point(143, 213);
            this.monitorWidthText.Name = "monitorWidthText";
            this.monitorWidthText.Size = new System.Drawing.Size(171, 29);
            this.monitorWidthText.TabIndex = 23;
            // 
            // monitorHeightLabel
            // 
            this.monitorHeightLabel.AutoSize = true;
            this.monitorHeightLabel.Location = new System.Drawing.Point(23, 251);
            this.monitorHeightLabel.Name = "monitorHeightLabel";
            this.monitorHeightLabel.Size = new System.Drawing.Size(114, 21);
            this.monitorHeightLabel.TabIndex = 26;
            this.monitorHeightLabel.Text = "Monitor height";
            // 
            // monitorHeightText
            // 
            this.monitorHeightText.Location = new System.Drawing.Point(143, 248);
            this.monitorHeightText.Name = "monitorHeightText";
            this.monitorHeightText.Size = new System.Drawing.Size(171, 29);
            this.monitorHeightText.TabIndex = 25;
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
            // sandboxieConfigurationPathText
            // 
            this.sandboxieConfigurationPathText.Location = new System.Drawing.Point(285, 135);
            this.sandboxieConfigurationPathText.Name = "sandboxieConfigurationPathText";
            this.sandboxieConfigurationPathText.Size = new System.Drawing.Size(171, 29);
            this.sandboxieConfigurationPathText.TabIndex = 29;
            // 
            // sandboxieConfigurationPathLabel
            // 
            this.sandboxieConfigurationPathLabel.AutoSize = true;
            this.sandboxieConfigurationPathLabel.Location = new System.Drawing.Point(138, 138);
            this.sandboxieConfigurationPathLabel.Name = "sandboxieConfigurationPathLabel";
            this.sandboxieConfigurationPathLabel.Size = new System.Drawing.Size(141, 21);
            this.sandboxieConfigurationPathLabel.TabIndex = 28;
            this.sandboxieConfigurationPathLabel.Text = "Configuration path";
            // 
            // maFilesPathLabel
            // 
            this.maFilesPathLabel.AutoSize = true;
            this.maFilesPathLabel.Location = new System.Drawing.Point(39, 286);
            this.maFilesPathLabel.Name = "maFilesPathLabel";
            this.maFilesPathLabel.Size = new System.Drawing.Size(98, 21);
            this.maFilesPathLabel.TabIndex = 31;
            this.maFilesPathLabel.Text = "maFiles path";
            // 
            // maFilesPathText
            // 
            this.maFilesPathText.Location = new System.Drawing.Point(143, 283);
            this.maFilesPathText.Name = "maFilesPathText";
            this.maFilesPathText.Size = new System.Drawing.Size(171, 29);
            this.maFilesPathText.TabIndex = 30;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maFilesPathLabel);
            this.Controls.Add(this.maFilesPathText);
            this.Controls.Add(this.sandboxieConfigurationPathText);
            this.Controls.Add(this.sandboxieConfigurationPathLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.monitorHeightLabel);
            this.Controls.Add(this.monitorHeightText);
            this.Controls.Add(this.monitorWidthLabel);
            this.Controls.Add(this.monitorWidthText);
            this.Controls.Add(this.generalLabel);
            this.Controls.Add(this.gamePortLabel);
            this.Controls.Add(this.gamePortText);
            this.Controls.Add(this.gameIPLabel);
            this.Controls.Add(this.gameIPText);
            this.Controls.Add(this.gameHeightLabel);
            this.Controls.Add(this.gameHeightText);
            this.Controls.Add(this.gameWidthLabel);
            this.Controls.Add(this.gameWidthText);
            this.Controls.Add(this.gameIDLabel);
            this.Controls.Add(this.gameIDText);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.sandboxiePathText);
            this.Controls.Add(this.steamPathText);
            this.Controls.Add(this.sandboxiePathLabel);
            this.Controls.Add(this.sandboxieLabel);
            this.Controls.Add(this.steamPathLabel);
            this.Controls.Add(this.steamLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "SteamGamePanel2 settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveButton;
        private Button cancelButton;
        private Label steamLabel;
        private Label steamPathLabel;
        private Label sandboxieLabel;
        private Label sandboxiePathLabel;
        private TextBox steamPathText;
        private TextBox sandboxiePathText;
        private Label gameLabel;
        private TextBox gameIDText;
        private Label gameIDLabel;
        private Label gameWidthLabel;
        private TextBox gameWidthText;
        private Label gameHeightLabel;
        private TextBox gameHeightText;
        private Label gameIPLabel;
        private TextBox gameIPText;
        private Label gamePortLabel;
        private TextBox gamePortText;
        private Label generalLabel;
        private Label monitorWidthLabel;
        private TextBox monitorWidthText;
        private Label monitorHeightLabel;
        private TextBox monitorHeightText;
        private Label settingsLabel;
        private TextBox sandboxieConfigurationPathText;
        private Label sandboxieConfigurationPathLabel;
        private Label maFilesPathLabel;
        private TextBox maFilesPathText;
    }
}