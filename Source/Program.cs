using Hush.Display;
using System;
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
