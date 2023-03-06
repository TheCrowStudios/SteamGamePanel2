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
    public partial class SplashForm : Form
    {
        public static Form CurrentSplashForm { get; set; }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        public static void ShowSplashForm()
        {
            Thread thread = new Thread(new ThreadStart(ShowSplashFormInThread));
            thread.Start();
        }

        static void ShowSplashFormInThread()
        {
            CurrentSplashForm = new SplashForm();
            CurrentSplashForm.Show();
        }

        public static void CloseSplashForm()
        {
            if (CurrentSplashForm == null) return;

            CurrentSplashForm.Invoke(CurrentSplashForm.Close);
        }
    }
}
