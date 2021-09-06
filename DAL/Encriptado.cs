using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace DAL
{
    public class Encriptado

    {

        public static string IV = "alkmdnekrpslaieb"; // 128

        public static string Key = "alkmdnekrpslaiebalkmdnekrpslaieb"; // 256

        public static string Salt = "asd";
        
        public static string AESEncrypt(string pDesencriptado)
        {
            byte[] textbyte = ASCIIEncoding.ASCII.GetBytes(pDesencriptado);

            AesCryptoServiceProvider Endec = new AesCryptoServiceProvider();

            //Seteo de parámetros
            Endec.BlockSize = 128;
            Endec.KeySize = 256;
            Endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            Endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            Endec.Padding = PaddingMode.PKCS7;
            Endec.Mode = CipherMode.CBC;
            //Fin de Seteo de parámetros

            ICryptoTransform icrypt = Endec.CreateEncryptor(Endec.Key, Endec.IV);
            
            byte[] enc = icrypt.TransformFinalBlock(textbyte, 0, textbyte.Length);
            icrypt.Dispose();

            return Convert.ToBase64String(enc);
        }


        public static string Decrypt(string pEncriptado)
        {
            byte[] encbytes = Convert.FromBase64String(pEncriptado);

            AesCryptoServiceProvider Endec = new AesCryptoServiceProvider();

            //Seteo de parámetros
            Endec.BlockSize = 128;
            Endec.KeySize = 256;
            Endec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            Endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            Endec.Padding = PaddingMode.PKCS7;
            Endec.Mode = CipherMode.CBC;
            //Fin de Seteo de parámetros

            ICryptoTransform icrypt = Endec.CreateDecryptor(Endec.Key, Endec.IV);


            byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
            icrypt.Dispose();

            return ASCIIEncoding.ASCII.GetString(dec);

        }



        public static string MDCinco(string pEntrada)
        {
            MD5 mD5 = new MD5CryptoServiceProvider();

            byte[] bytes = mD5.ComputeHash(Encoding.Unicode.GetBytes(pEntrada + Salt));

            string salida = BitConverter.ToString(bytes).Replace("-", String.Empty);

            return salida.ToLower();
            
        }
        


    }
}
