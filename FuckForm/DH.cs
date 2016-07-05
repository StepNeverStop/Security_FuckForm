using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FuckForm
{
    public class DH
    {
        public static string[] go(string mess)
        {
            return Alice.alice(mess);
        }
    }
    public class Alice
    {
        public static byte[] alicePublicKey;

        public static string[] alice(string mess)
        {
            using (ECDiffieHellmanCng alice = new ECDiffieHellmanCng())
            {
                //派生密钥
                alice.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                alice.HashAlgorithm = CngAlgorithm.Sha256;
                alicePublicKey = alice.PublicKey.ToByteArray();
                Bob bob = new Bob();
                CngKey k = CngKey.Import(bob.bobPublicKey, CngKeyBlobFormat.EccPublicBlob);
                //用bob的公钥来生成Alice的私钥
                byte[] aliceKey = alice.DeriveKeyMaterial(CngKey.Import(bob.bobPublicKey, CngKeyBlobFormat.EccPublicBlob));
                byte[] encryptedMessage = null;
                byte[] iv = null;
                //用Alice的私钥来加密信息
                Send(aliceKey, mess, out encryptedMessage, out iv);
                string[] value = new string[2];
                value[0] = Encoding.UTF8.GetString(encryptedMessage);
                value[1] = bob.Receive(encryptedMessage, iv);
                return value;
            }

        }

        private static void Send(byte[] key, string secretMessage, out byte[] encryptedMessage, out byte[] iv)
        {
            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = key;
                iv = aes.IV;

                // Encrypt the message
                using (MemoryStream ciphertext = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ciphertext, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] plaintextMessage = Encoding.UTF8.GetBytes(secretMessage);
                    cs.Write(plaintextMessage, 0, plaintextMessage.Length);
                    cs.Close();
                    encryptedMessage = ciphertext.ToArray();
                }
            }
        }

    }
    public class Bob
    {
        //bob公钥
        public byte[] bobPublicKey;
        private byte[] bobKey;
        public Bob()
        {
            using (ECDiffieHellmanCng bob = new ECDiffieHellmanCng())
            {
                //密钥派生函数
                bob.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                //设置生成密钥时的哈希算法
                bob.HashAlgorithm = CngAlgorithm.Sha256;
                bobPublicKey = bob.PublicKey.ToByteArray();
                bobKey = bob.DeriveKeyMaterial(CngKey.Import(Alice.alicePublicKey, CngKeyBlobFormat.EccPublicBlob));

            }
        }

        public string Receive(byte[] encryptedMessage, byte[] iv)
        {

            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.Key = bobKey;
                aes.IV = iv;
                // Decrypt the message
                //用bob的私钥解密
                using (MemoryStream plaintext = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(plaintext, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedMessage, 0, encryptedMessage.Length);
                        cs.Close();
                        return Encoding.UTF8.GetString(plaintext.ToArray());

                    }
                }
            }
        }

    }
}
