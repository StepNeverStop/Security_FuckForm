using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FuckForm
{
    public class SHA1
    {

        public static string ByteToString(byte[] bytHash, bool toUpper = true)
        {
            string sHash = "", sTemp = "";
            for (int counter = 0; counter < bytHash.Count(); counter++)
            {
                long i = bytHash[counter] / 16;
                if (i > 9)
                {
                    sTemp = ((char)(i - 10 + 0x41)).ToString();
                }
                else
                {
                    sTemp = ((char)(i + 0x30)).ToString();
                }
                i = bytHash[counter] % 16;
                if (i > 9)
                {
                    sTemp += ((char)(i - 10 + 0x41)).ToString();
                }
                else
                {
                    sTemp += ((char)(i + 0x30)).ToString();
                }
                sHash += sTemp;
            }
            return toUpper ? sHash : sHash.ToLower();
        }
        /// <summary>
        /// 计算SHA-1码
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_SHA_1(string str, bool toUpper = true)
        {
            try
            {
                System.Security.Cryptography.SHA1CryptoServiceProvider SHA1CSP
                    = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                //将待散列的字符串转换为字节序列
                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(str);
                //计算指定字节数组的哈希值
                byte[] bytHash = SHA1CSP.ComputeHash(bytValue);
                SHA1CSP.Clear();

                //根据计算得到的Hash码翻译为SHA-1码

                //根据大小写规则决定返回的字符串
                return ByteToString(bytHash, toUpper);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 计算SHA-256码
        /// </summary>
        /// <param name="word">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_SHA_256(string word, bool toUpper = true)
        {
            try
            {
                System.Security.Cryptography.SHA256CryptoServiceProvider SHA256CSP
                    = new System.Security.Cryptography.SHA256CryptoServiceProvider();

                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(word);
                byte[] bytHash = SHA256CSP.ComputeHash(bytValue);
                SHA256CSP.Clear();

                //根据计算得到的Hash码翻译为SHA-1码

                //根据大小写规则决定返回的字符串
                return ByteToString(bytHash, toUpper);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 计算SHA-384码
        /// </summary>
        /// <param name="word">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_SHA_384(string word, bool toUpper = true)
        {
            try
            {
                System.Security.Cryptography.SHA384CryptoServiceProvider SHA384CSP
                    = new System.Security.Cryptography.SHA384CryptoServiceProvider();

                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(word);
                byte[] bytHash = SHA384CSP.ComputeHash(bytValue);
                SHA384CSP.Clear();

                //根据计算得到的Hash码翻译为SHA-1码

                //根据大小写规则决定返回的字符串
                return ByteToString(bytHash, toUpper);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 计算SHA-512码
        /// </summary>
        /// <param name="word">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_SHA_512(string word, bool toUpper = true)
        {
            try
            {
                System.Security.Cryptography.SHA512CryptoServiceProvider SHA512CSP
                    = new System.Security.Cryptography.SHA512CryptoServiceProvider();

                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(word);
                byte[] bytHash = SHA512CSP.ComputeHash(bytValue);
                SHA512CSP.Clear();

                //根据计算得到的Hash码翻译为SHA-1码
                //根据大小写规则决定返回的字符串
                return ByteToString(bytHash, toUpper);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //文件散列
        public static string FileSHA(string filepath)
        {
            using (System.Security.Cryptography.SHA512CryptoServiceProvider SHA
                    = new System.Security.Cryptography.SHA512CryptoServiceProvider())
            {
                using (FileStream fs = File.OpenRead(filepath))
                {
                    //散列
                    byte[] output = SHA.ComputeHash(fs);
                    return BitConverter.ToString(output).Replace("-", "");
                }
            }
        }
    }
}
