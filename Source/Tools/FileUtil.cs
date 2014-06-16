using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hush.Tools
{

    static class FileUtil
    {

        public static void OutputScriptData(String Data)
        {
            String Name = DateTime.Now.ToString(@"MM dd yyyy h mm tt") + ".html";
            File.Create(Name).Close();
            using (StreamWriter W = new StreamWriter(Name, true))
            {
                W.Write(Data);
            }

        }

        public static String ReadDataFile(String FileName)
        {
            return String.Empty;
        }

        private static String ReadFile(String FileName)
        {

            if (!File.Exists(FileName))
            {

                Console.WriteLine("unable to find file: " + FileName);
                return String.Empty;

            }

            StringBuilder Builder = new StringBuilder();
            String Line = String.Empty;
            StreamReader Reader = new StreamReader(FileName);

            while ((Line = Reader.ReadLine()) != null)
            {

                Builder.AppendLine(Line);

            }

            Reader.Dispose();
            return Builder.ToString();

        }

        public static String ReadScriptFile(String FileName)
        {

            return ReadFile(FileName + ".js");

        }

        public static Boolean SaveDataFile(Object Data)
        {
            return false;
        }

    }

}
