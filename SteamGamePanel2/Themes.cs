using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGamePanelUI
{
    public class Themes
    {
        public static Icon ProgramIcon { get; set; } = new Icon("SGP.ico");

        public static void SetFormTheme(Form _form)
        {
            _form.Icon = ProgramIcon;
        }
    }
}
