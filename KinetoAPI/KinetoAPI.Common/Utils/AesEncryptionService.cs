using System;
using System.IO;
using System.Security.Cryptography;

namespace KinetoAPI.Common.Utils
{
    public class AesEncryptionService
    {
        private static readonly byte[] AesKey = { 43, 20, 0, 251, 217, 124, 90, 211, 73, 199, 46, 247, 75, 59, 45, 134, 245, 190, 240, 95, 106, 119, 123, 240, 158, 101, 175, 106, 42, 252, 176, 114 };
        private static readonly byte[] AesIV = { 121, 135, 162, 12, 86, 109, 33, 17, 99, 185, 244, 134, 3, 18, 152, 191 };

        public static string Encrypt(string plainText)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException(nameof(plainText));

            string encryptedText;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = AesKey;
                aesAlg.IV = AesIV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    var encrypted = msEncrypt.ToArray();

                    encryptedText = Convert.ToBase64String(encrypted);
                }
            }

            return encryptedText;
        }

        public static string Decrypt(string encryptedText)
        {
            if (encryptedText == null || encryptedText.Length <= 0)
                throw new ArgumentNullException(nameof(encryptedText));

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = AesKey;
                aesAlg.IV = AesIV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    plaintext = srDecrypt.ReadToEnd();
                }
            }

            return plaintext;
        }
    }
}