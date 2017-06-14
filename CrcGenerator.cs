using System;
using System.IO;
using System.Security.Cryptography;

namespace CrcGenerator
{
    public class CrcGenerator
    {
        public static string GetCrcSHA1(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new NullReferenceException("The fileName is null or empty.");
            }
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Can not find the file to compute CRC.");
            }

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            SHA1 sManaged = new SHA1Managed();
            byte[] crc = sManaged.ComputeHash(fs);
            fs.Close();

            return BitConverter.ToString(crc).Replace("-", "");
        }

        public static string GetCrcSHA256(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new NullReferenceException("The fileName is null or empty.");
            }
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Can not find the file to compute CRC.");
            }

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            SHA256 sManaged = new SHA256Managed();
            byte[] crc = sManaged.ComputeHash(fs);
            fs.Close();

            return BitConverter.ToString(crc).Replace("-", "");
        }

        public static string GetCrcSHA512(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new NullReferenceException("The fileName is null or empty.");
            }
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Can not find the file to compute CRC.");
            }

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            SHA512 sManaged = new SHA512Managed();
            byte[] crc = sManaged.ComputeHash(fs);
            fs.Close();

            return BitConverter.ToString(crc).Replace("-", "");
        }
    }
}
