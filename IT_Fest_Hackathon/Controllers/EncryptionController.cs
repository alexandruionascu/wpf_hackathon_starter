using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace IT_Fest_Hackathon.Controllers
{
    public static class EncryptionController
    {
        private static string encryptionKey { get { return "q?=+L^NQ2016"; } }

        public static string encrypt(string data)
        {
            var clearBytes = Encoding.Unicode.GetBytes(data);

            using (var encryptor = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = key.GetBytes(32);
                encryptor.IV = key.GetBytes(16);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(clearBytes, 0, clearBytes.Length);
                        cryptoStream.Close();
                    }

                    data = Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            return data;
        }

        public static string decrypt(string data)
        {
            var cipherBytes = Convert.FromBase64String(data);

            using (var encryptor = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = key.GetBytes(32);
                encryptor.IV = key.GetBytes(16);

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
                        cryptoStream.Close();
                    }

                    data = Encoding.Unicode.GetString(memoryStream.ToArray());
                }
            }

            return data;
        }
    }
}
