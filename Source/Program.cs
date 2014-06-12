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

            // this is testing code to run the testing.js file
            if (File.Exists("testing.js"))
            {
                HushScript x = new HushScript();
                x.Name = "testing";
                ReturnValue status = x.Load();
            //    if (status.Success == false)
              //  {
                 //   MessageBox.Show(status.Message);
               // }
                x.Run();
            }

            Window = new ParentWindow();
            Application.Run(Window);

        }

    }

}
