using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckForm
{
    public class UserVerify
    {
        public static string user = "wjs";
        public static string md5Pwd = MD5.MD5E("123");
        public static string shaPwd = SHA1.Hash_SHA_1("123");

        public static bool MD5UserVerify(string pwd)
        {
            return md5Pwd.Equals(MD5.MD5E(pwd));
        }

        public static bool SHAUserVerify(string pwd)
        {
            return shaPwd.Equals(SHA1.Hash_SHA_1(pwd));
        }
    }
}
