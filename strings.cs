using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Resources;

namespace Nomlyzer
{
    class Strings
    {
        public string obtenerVersion()
        {
            string s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString() + "." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
            return s;
        }
    }
}
