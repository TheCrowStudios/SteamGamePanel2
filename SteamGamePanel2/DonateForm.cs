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
    public partial class DonateForm : Form
    {
        public static string MoneroAddress { get; set; } = "85WQMUfQ72CNtG5M1GNx92RnNdM91jEMQBevdCxCrbKyYB3d4oakjhagPygTMbKZV6HTd4Gk5T4A6cNwRqaAFTrb1fgrPFs";

        public DonateForm()
        {
            InitializeComponent();
        }

        private void DonateForm_Load(object sender, EventArgs e)
        {
            moneroAddressLabel.Text = $"{MoneroAddress.Substring(0, 4)}...{MoneroAddress.Substring(MoneroAddress.Length - 4, 4)}";


            Themes.SetFormTheme(this);
        }

        private void moneroAddressLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MoneroAddress);
        }
    }
}
