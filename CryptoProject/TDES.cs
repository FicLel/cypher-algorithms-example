using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CryptoProject
{
    class TDES
    {
        public String generateKeysTDES()
        {
            try
            {
                TripleDES tpd = TripleDES.Create();

                tpd.GenerateKey();
                //Console.WriteLine(Convert.ToBase64String(tpd.Key));
                return Convert.ToBase64String(tpd.Key);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return "";
        }
        public String encript(String texto, String key)
        {
            byte[] iv = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };

            var newKey = MD5.Create().ComputeHash(Convert.FromBase64String(key));
            //Console.WriteLine(tpd.KeySize);
            //tpd.IV = iv;
            using (TripleDES tpd = TripleDES.Create())
            {
                //Console.WriteLine(texto);
                tpd.Mode = CipherMode.ECB;
                ICryptoTransform encriptor = tpd.CreateEncryptor(newKey, iv);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encriptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(texto);
                        }
                        var encrypted = msEncrypt.ToArray();
                        //Console.WriteLine(encrypted.Length);
                        //Console.WriteLine(Convert.ToBase64String(encrypted));
                        return Convert.ToBase64String(encrypted);

                    }
                }
            }
            
        }
        public String decript(String key, String text)
        {
            byte[] texto = Convert.FromBase64String(text);
            byte[] iv = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };

            var newKey = MD5.Create().ComputeHash(Convert.FromBase64String(key));
            String encrypted = null;
            using (TripleDES tpd = TripleDES.Create())
            {
                //Console.WriteLine(texto);
                tpd.Mode = CipherMode.ECB;
                ICryptoTransform encriptor = tpd.CreateDecryptor(newKey, iv);
                using (MemoryStream msEncrypt = new MemoryStream(texto))
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encriptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader swEncrypt = new StreamReader(csEncrypt))
                        {
                            encrypted = swEncrypt.ReadToEnd();
                        }
                        //var encrypted = msEncrypt.ToArray();
                        //Console.WriteLine(encrypted.Length);
                        //Console.WriteLine(Convert.ToBase64String(encrypted));
                        return encrypted;

                    }
                }
            }
        }
        public static string Decrypt(string textToDecrypt, string key)
        {
            TripleDESCryptoServiceProvider TDESCryptoProvider = new TripleDESCryptoServiceProvider();

            MD5CryptoServiceProvider hashService = new MD5CryptoServiceProvider();

            byte[] byteKeyHash = hashService.ComputeHash(Convert.FromBase64String(key));

            byte[] iv = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B };

            byte[] byteDecryptArray = Convert.FromBase64String(textToDecrypt);

            hashService.Clear();

            TDESCryptoProvider.Key = byteKeyHash;
            TDESCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB

            var myDecryptor = TDESCryptoProvider.CreateDecryptor(TDESCryptoProvider.Key, iv);
            var transformedArray = myDecryptor.TransformFinalBlock(byteDecryptArray, 0, byteDecryptArray.Length);

            string plaintext = UTF8Encoding.UTF8.GetString(transformedArray);

            TDESCryptoProvider.Clear();
            return plaintext;
        }

    }
}
