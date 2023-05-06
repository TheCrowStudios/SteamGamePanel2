namespace SteamGamePanelUI
{
    partial class DonateForm
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
            this.moneroLabel = new System.Windows.Forms.Label();
            this.moneroAddressLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.clickToCopyLabel = new System.Windows.Forms.Label();
            this.donateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moneroLabel
            // 
            this.moneroLabel.AutoSize = true;
            this.moneroLabel.Location = new System.Drawing.Point(62, 84);
            this.moneroLabel.Name = "moneroLabel";
            this.moneroLabel.Size = new System.Drawing.Size(68, 21);
            this.moneroLabel.TabIndex = 34;
            this.moneroLabel.Text = "Monero:";
            // 
            // moneroAddressLabel
            // 
            this.moneroAddressLabel.AutoSize = true;
            this.moneroAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.moneroAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.moneroAddressLabel.Location = new System.Drawing.Point(136, 84);
            this.moneroAddressLabel.Name = "moneroAddressLabel";
            this.moneroAddressLabel.Size = new System.Drawing.Size(87, 21);
            this.moneroAddressLabel.TabIndex = 35;
            this.moneroAddressLabel.Text = "<Monero>";
            this.moneroAddressLabel.Click += new System.EventHandler(this.moneroAddressLabel_Click);
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
            // clickToCopyLabel
            // 
            this.clickToCopyLabel.AutoSize = true;
            this.clickToCopyLabel.Location = new System.Drawing.Point(351, 357);
            this.clickToCopyLabel.Name = "clickToCopyLabel";
            this.clickToCopyLabel.Size = new System.Drawing.Size(98, 21);
            this.clickToCopyLabel.TabIndex = 39;
            this.clickToCopyLabel.Text = "Click to copy";
            // 
            // donateLabel
            // 
            this.donateLabel.AutoSize = true;
            this.donateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.donateLabel.Location = new System.Drawing.Point(357, 32);
            this.donateLabel.Name = "donateLabel";
            this.donateLabel.Size = new System.Drawing.Size(81, 30);
            this.donateLabel.TabIndex = 40;
            this.donateLabel.Text = "Donate";
            this.donateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DonateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.donateLabel);
            this.Controls.Add(this.clickToCopyLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.moneroAddressLabel);
            this.Controls.Add(this.moneroLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DonateForm";
            this.Text = "SteamGamePanel2 donate";
            this.Load += new System.EventHandler(this.DonateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label moneroLabel;
        private Label moneroAddressLabel;
        private Label versionLabel;
        private Label clickToCopyLabel;
        private Label donateLabel;
    }
}