using System;
using System.Windows.Forms;

using Hush.Display;
using Hush.Display.Interfaces;

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
