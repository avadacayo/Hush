using Hush.Client.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hush.Tools
{

    static class FileUtil
    {

        public static readonly String DataDirectory = "." + Path.DirectorySeparatorChar + "Data" + Path.DirectorySeparatorChar;
        public static readonly String Extension = ".user";
        public static readonly String ScriptExtension = ".js";

        public static List<String> FindUserFiles()
        {

            List<String> FileList;
            FileList = new List<String>(Directory.GetFiles(DataDirectory, "*" + Extension));
            return FileList;

        }

        public static List<String> GetScriptList(String Template)
        {

            List<String> ReturnValue = new List<String>();

            if (Directory.Exists(DataDirectory + "Templates" + Path.DirectorySeparatorChar + Template))
            {

                String[] Files = Directory.GetFiles(DataDirectory + "Templates" + Path.DirectorySeparatorChar + Template);

                foreach (String FileName in Files)
                {

                    if (FileName.EndsWith(".js"))
                    {

                        ReturnValue.Add(Path.GetFileNameWithoutExtension(FileName));

                    }

                }

            }

            return ReturnValue;

        }

        public static String GetUserFileName(User User, Boolean WithPath)
        {

            String BaseFileName = String.Empty;
            BaseFileName = Encryption.ToMD5(User.Username) + Extension;

            if (WithPath)
            {

                return DataDirectory + BaseFileName;

            }

            return BaseFileName;

        }

        private static String ReadFile(String FileName)
        {

            System.Console.WriteLine(FileName);

            if (!File.Exists(FileName))
            {

                return String.Empty;

            }

            StreamReader Reader = new StreamReader(FileName);
            String Line = String.Empty;
            StringBuilder Builder = new StringBuilder();

            while ((Line = Reader.ReadLine()) != null)
            {

                Builder.AppendLine(Line);

            }

            Reader.Dispose();
            return Builder.ToString();

        }

        public static String ReadScriptFile(String TemplateName, String FunctionName)
        {

            if (TemplateName.Length < 1 || FunctionName.Length < 1)
            {

                return String.Empty;

            }

            return ReadFile(DataDirectory + TemplateName + Path.DirectorySeparatorChar + FunctionName + ScriptExtension);

        }

    }

}
