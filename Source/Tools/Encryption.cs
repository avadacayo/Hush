using System;
using System.Security.Cryptography;
using System.Text;

namespace Hush.Tools
{

    class Encryption
    {
        public static String GenerateKey()
        {
            TripleDESCryptoServiceProvider TripleDESProvider = new TripleDESCryptoServiceProvider();
            TripleDESProvider.GenerateKey();
            Byte[] Key = TripleDESProvider.Key;
            return System.Text.Encoding.Default.GetString(Key); 
        }
        public static String FromBase64(String ToDecrypt)
        {

            Byte[] Data = Convert.FromBase64String(ToDecrypt);
            return StringUtil.GetString(Data);

        }

        public static String FromTripleDES(String ToDecrypt, String Key)
        {

            MD5CryptoServiceProvider MD5Provider = new MD5CryptoServiceProvider();
            Byte[] KeyArray = MD5Provider.ComputeHash(StringUtil.GetBytes(Key));
            MD5Provider.Clear();
            Byte[] ToDecryptArray = StringUtil.GetBytes(FromBase64(ToDecrypt));
            TripleDESCryptoServiceProvider TripleDESProvider = new TripleDESCryptoServiceProvider();
            TripleDESProvider.Key = KeyArray;
            TripleDESProvider.Mode = CipherMode.ECB;
            TripleDESProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform Decryptor = TripleDESProvider.CreateDecryptor();
            Byte[] ResultArray = Decryptor.TransformFinalBlock(ToDecryptArray, 0, ToDecryptArray.Length);
            TripleDESProvider.Clear();
            return StringUtil.GetString(ResultArray);

        }

        public static String ToBase64(String ToEncrypt)
        {

            Byte[] Data = StringUtil.GetBytes(ToEncrypt);
            return Convert.ToBase64String(Data);

        }

        public static String ToMD5(String ToEncrypt)
        {

            MD5 Hasher = MD5.Create();
            StringBuilder Builder = new StringBuilder();
            Byte[] Data = Hasher.ComputeHash(StringUtil.GetBytes(ToEncrypt));

            for (Int32 Index = 0; Index < Data.Length; Index++)
            {
                Builder.Append(Data[Index].ToString("x2"));
            }

            return Builder.ToString();

        }

        public static String ToTripleDES(String ToEncrypt, String Key)
        {

            MD5CryptoServiceProvider MD5Provider = new MD5CryptoServiceProvider();
            Byte[] KeyArray = MD5Provider.ComputeHash(StringUtil.GetBytes(Key));
            MD5Provider.Clear();
            Byte[] ToEncryptArray = StringUtil.GetBytes(ToEncrypt);
            TripleDESCryptoServiceProvider TripleDESProvider = new TripleDESCryptoServiceProvider();
            TripleDESProvider.Key = KeyArray;
            TripleDESProvider.Mode = CipherMode.ECB;
            TripleDESProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform Encryptor = TripleDESProvider.CreateEncryptor();
            Byte[] ResultArray = Encryptor.TransformFinalBlock(ToEncryptArray, 0, ToEncryptArray.Length);
            TripleDESProvider.Clear();
            return ToBase64(StringUtil.GetString(ResultArray)); ;

        }

    }

}
