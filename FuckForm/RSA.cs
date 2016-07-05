using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FuckForm
{
    public class RSA
    {
        /// <summary>
        /// 取得密钥对
        /// </summary>
        /// <returns></returns>
        public static string[] GenerateKeys()
        {
            string[] sKeys = new String[2];
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //私钥
            sKeys[0] = rsa.ToXmlString(true);
            //公钥
            sKeys[1] = rsa.ToXmlString(true);
            return sKeys;
        }
        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="plaintext">明文</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>密文字符串</returns>
        public static string EncryptByRSA(string plaintext, string publicKey)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(plaintext);
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKey);
                byte[] encryptedData = RSA.Encrypt(dataToEncrypt, false);
                return Convert.ToBase64String(encryptedData);
            }
        }
        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="ciphertext">密文</param>
        /// <param name="privateKey">私钥</param>
        /// <returns>明文字符串</returns>
        public static string DecryptByRSA(string ciphertext, string privateKey)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKey);
                byte[] encryptedData = Convert.FromBase64String(ciphertext);
                byte[] decryptedData = RSA.Decrypt(encryptedData, false);
                return byteConverter.GetString(decryptedData);
            }
        }

        //签名
        public static string SignByRSA(string plaintext, string privateKey)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(plaintext);
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKey);
                byte[] encryptedData = RSA.Encrypt(dataToEncrypt, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        //认证
        public static string IdentifyByRSA(string ciphertext, string publicKey)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKey);
                byte[] encryptedData = Convert.FromBase64String(ciphertext);
                byte[] decryptedData = RSA.Decrypt(encryptedData, false);
                return byteConverter.GetString(decryptedData);
            }
        }
    }
}
