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

        public static List<String> ReadTemplate(String TemplateName)
        {

            if (TemplateName.Trim().Length < 1)
            {

                return new List<String>();

            }

            String FileName = DataDirectory + "Templates" + Path.DirectorySeparatorChar + TemplateName + Path.DirectorySeparatorChar + "template.t";
            List<String> ReturnValue = new List<String>();

            if (File.Exists(FileName))
            {

                StreamReader Reader = new StreamReader(FileName);
                String Line = String.Empty;

                while ((Line = Reader.ReadLine()) != null)
                {

                    if (Line.Trim().Length >= 0)
                    {
                        ReturnValue.Add(Line);
                    }

                }

                Reader.Dispose();

            }

            return ReturnValue;

        }

        public static List<String> GetTemplateList()
        {

            List<String> ReturnValue = new List<String>();

            if (Directory.Exists(DataDirectory + "Templates"))
            {

                String[] Files = Directory.GetDirectories(DataDirectory + "Templates");

                foreach (String DirName in Files)
                {

                    ReturnValue.Add(Path.GetFileName(Path.GetDirectoryName(DirName + Path.DirectorySeparatorChar)));

                }

            }

            return ReturnValue;

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

            return ReadFile(DataDirectory + "Templates" + Path.DirectorySeparatorChar + TemplateName + Path.DirectorySeparatorChar + FunctionName + ScriptExtension);

        }

    }

}
