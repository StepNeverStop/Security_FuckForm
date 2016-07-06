using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckForm
{
    public static class CA
    {
        public static string CARSAprivateKey;
        public static string CARSApublicKey;
    }

    public static class Credential
    {
        public static string Version = "V3";
        public static string Num = "01";
        public static string signmethod = "DESRSA";
        public static string org = "CA Virtual";
        public static DateTime timenow;
        public static DateTime timeto;
        public static string user;
        public static string publickey;
        public static string casign;
        public static string privatekey;
    }

    public static class vs
    {
        public static string vstring;
    }
}
