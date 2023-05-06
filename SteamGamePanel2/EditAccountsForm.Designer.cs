namespace SteamGamePanelUI
{
    partial class EditAccountsForm
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.accountsList = new System.Windows.Forms.ListView();
            this.usernameHeader = new System.Windows.Forms.ColumnHeader();
            this.processIDHeader = new System.Windows.Forms.ColumnHeader();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Location = new System.Drawing.Point(57, 323);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(130, 50);
            this.addUserButton.TabIndex = 6;
            this.addUserButton.Text = "Add account";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(193, 323);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(130, 50);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(144, 112);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(171, 29);
            this.usernameText.TabIndex = 10;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(57, 115);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 21);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(62, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 21);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(144, 147);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(171, 29);
            this.passwordText.TabIndex = 12;
            // 
            // accountsList
            // 
            this.accountsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accountsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameHeader,
            this.processIDHeader});
            this.accountsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.accountsList.Location = new System.Drawing.Point(526, 81);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(262, 233);
            this.accountsList.TabIndex = 14;
            this.accountsList.UseCompatibleStateImageBehavior = false;
            this.accountsList.View = System.Windows.Forms.View.Details;
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
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Location = new System.Drawing.Point(57, 194);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(75, 21);
            this.notifyLabel.TabIndex = 15;
            this.notifyLabel.Text = "<Notify>";
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountsLabel.Location = new System.Drawing.Point(351, 32);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(99, 30);
            this.accountsLabel.TabIndex = 28;
            this.accountsLabel.Text = "Accounts";
            this.accountsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Add Steam account";
            // 
            // EditAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.accountsLabel);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addUserButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditAccountsForm";
            this.Text = "SteamGamePanel2 edit accounts";
            this.Load += new System.EventHandler(this.EditAccountsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addUserButton;
        private Button removeButton;
        private TextBox usernameText;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordText;
        private ListView accountsList;
        private ColumnHeader usernameHeader;
        private ColumnHeader processIDHeader;
        private Label notifyLabel;
        private Label accountsLabel;
        private Label versionLabel;
        private Label label1;
    }
}