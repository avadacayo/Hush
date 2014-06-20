using System;

namespace Hush.Tools
{

    class StringUtil
    {

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
