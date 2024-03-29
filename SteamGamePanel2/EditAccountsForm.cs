﻿using SteamGamePanelLibrary;
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
    public partial class EditAccountsForm : Form
    {
        public Configuration Config { get; set; }

        public EditAccountsForm(Configuration _configuration)
        {
            InitializeComponent();
            Config = _configuration;
        }

        private void EditAccountsForm_Load(object sender, EventArgs e)
        {
            notifyLabel.Text = "";
            UpdateUserList();
            Themes.SetFormTheme(this);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(usernameText.Text) || String.IsNullOrWhiteSpace(passwordText.Text)) return;

            if (Config.AddSteamUser(usernameText.Text, passwordText.Text)) notifyLabel.Text = $"Added user {usernameText.Text}";
            else
            {
                notifyLabel.Text = $"Could not add user {usernameText.Text}";
                return;
            }

            usernameText.Text = "";
            passwordText.Text = "";
            UpdateUserList();
        }

        void UpdateUserList()
        {
            accountsList.Items.Clear();
            
            for (int i = 0; i < Config.SteamUsers.Count; i++)
            {
                accountsList.Items.Add(Config.SteamUsers[i].Username);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (accountsList.SelectedItems.Count == 0) return;

            notifyLabel.Text = "";
            
            for (int i = 0; i < accountsList.SelectedItems.Count; i++)
            {
                if (Config.RemoveSteamUser(accountsList.SelectedItems[i].Text)) notifyLabel.Text += $"Removed user {accountsList.SelectedItems[i].Text}\n";
                else notifyLabel.Text += $"Could not remove user {accountsList.SelectedItems[i].Text}\n";
            }

            UpdateUserList();
        }
    }
}
