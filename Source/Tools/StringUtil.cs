using Newtonsoft.Json;
using System;

namespace Hush.Tools
{

    class StringUtil
    {

        public class JSON
        {

            public static T Deserialize<T>(String ToDeserialize)
            {

                T Result = default(T);
                Result = JsonConvert.DeserializeObject<T>(ToDeserialize);
                return Result;

            }

            public static String Serialize<T>(T ToSerialize)
            {

                String Result;
                Result = JsonConvert.SerializeObject(ToSerialize);
                return Result;

            }

            public static String SerializeFormatted<T>(T ToSerialize)
            {

                String Result;
                Result = JsonConvert.SerializeObject(ToSerialize, Formatting.Indented);
                return Result;

            }

        }

        public static Byte[] GetBytes(String Input)
        {

            Byte[] Result = new Byte[Input.Length * sizeof(Char)];
            Buffer.BlockCopy(Input.ToCharArray(), 0, Result, 0, Result.Length);
            return Result;

        }

        public static String GetString(Byte[] Input)
        {

            Char[] Result = new Char[Input.Length / sizeof(Char)];
            Buffer.BlockCopy(Input, 0, Result, 0, Input.Length);
            return new String(Result);

        }

    }

}
