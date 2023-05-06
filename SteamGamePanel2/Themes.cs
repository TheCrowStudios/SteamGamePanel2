using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanelUI
{
    public class Themes
    {
        public static string Version { get; set; } = "v1.0.0-alpha";
        public static Icon ProgramIcon { get; set; } = new Icon("SGP.ico");

        public static void SetFormTheme(Form _form)
        {
            for (int i = 0; i < _form.Controls.Count; i++)
            {
                if (_form.Controls[i].Name == "versionLabel")
                {
                    _form.Controls[i].Text = Version;
                    break;
                }
            }
            
            _form.Icon = ProgramIcon;
        }
    }
}
