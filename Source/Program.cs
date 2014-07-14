using Hush.Client;
using Hush.Display;
using Hush.Tools;
using Hush.Tools.Scripting;
using System;
using System.IO;
using System.Windows.Forms;

namespace Hush
{

    static class Program
    {

        public static ParentWindow Window;

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Window = new ParentWindow();
            Application.Run(Window);

        }

    }

}
