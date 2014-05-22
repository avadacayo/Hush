using System;
using System.Windows.Forms;

using Hush.Display.Interfaces;

namespace Hush
{

    static class Program
    {

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Settings());

        }

    }

}
