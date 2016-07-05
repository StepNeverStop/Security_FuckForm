using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FuckForm
{
    public class MD5
    {


        //密码散列
        public static string MD5E(string pwd)
        {
            //转换成字节流
            byte[] result = Encoding.Default.GetBytes(pwd.Trim());
            System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
            //加密
            byte[] output = md5.ComputeHash(result);
            //转换成字符串
            return BitConverter.ToString(output).Replace("-", "");
        }
        //文件散列
        public static string FileMD5E(string filepath)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                using (FileStream fs = File.OpenRead(filepath))
                {
                    //散列
                    byte[] output = md5.ComputeHash(fs);
                    return BitConverter.ToString(output).Replace("-", "");
                }
            }
        }

        /// <summary>
        /// 计算32位MD5码
        /// </summary>
        /// <param name="word">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_MD5_32(string word, bool toUpper = true)
        {
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider MD5CSP
                    = new System.Security.Cryptography.MD5CryptoServiceProvider();

                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(word);
                byte[] bytHash = MD5CSP.ComputeHash(bytValue);
                MD5CSP.Clear();

                //根据计算得到的Hash码翻译为MD5码

                //根据大小写规则决定返回的字符串
                return ByteToString(bytHash, toUpper);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 计算16位MD5码
        /// </summary>
        /// <param name="word">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_MD5_16(string word, bool toUpper = true)
        {
            try
            {
                string sHash = Hash_MD5_32(word).Substring(8, 16);
                return toUpper ? sHash : sHash.ToLower();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 计算32位2重MD5码
        /// </summary>
        /// <param name="word">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_2_MD5_32(string word, bool toUpper = true)
        {
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider MD5CSP
                    = new System.Security.Cryptography.MD5CryptoServiceProvider();

                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(word);
                byte[] bytHash = MD5CSP.ComputeHash(bytValue);

                //根据计算得到的Hash码翻译为MD5码

                bytValue = System.Text.Encoding.UTF8.GetBytes(ByteToString(bytHash, toUpper));
                bytHash = MD5CSP.ComputeHash(bytValue);
                MD5CSP.Clear();

                //根据大小写规则决定返回的字符串
                return ByteToString(bytHash, toUpper);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 计算16位2重MD5码
        /// </summary>
        /// <param name="word">字符串</param>
        /// <param name="toUpper">返回哈希值格式 true：英文大写，false：英文小写</param>
        /// <returns></returns>
        public static string Hash_2_MD5_16(string word, bool toUpper = true)
        {
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider MD5CSP
                        = new System.Security.Cryptography.MD5CryptoServiceProvider();

                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(word);
                byte[] bytHash = MD5CSP.ComputeHash(bytValue);

                //根据计算得到的Hash码翻译为MD5码

                string sHash = ByteToString(bytHash, toUpper).Substring(8, 16);

                bytValue = System.Text.Encoding.UTF8.GetBytes(sHash);
                bytHash = MD5CSP.ComputeHash(bytValue);
                MD5CSP.Clear();

                return ByteToString(bytHash, toUpper);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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
    }
}
