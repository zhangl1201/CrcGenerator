using System;

namespace CrcGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;
            bool launchOnCmd = false;
            if (args.Length >= 1)
            {
                filePath = args[0];
                launchOnCmd = true;
            }
            else
            {
                Console.WriteLine("Please input the integrated path of the file you want to compute hash code. FilePath:");
                filePath = Console.ReadLine();
            }
            Console.WriteLine(filePath);

            try
            {
                Console.WriteLine("SHA1" + "\t" + CrcGenerator.GetCrcSHA1(filePath));
                Console.WriteLine("SHA256" + "\t" + CrcGenerator.GetCrcSHA256(filePath));
                Console.WriteLine("SHA512" + "\t" + CrcGenerator.GetCrcSHA512(filePath));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            if (!launchOnCmd)
            {
                Console.WriteLine("Press any key to exit......");
                Console.Read();
            }
        }
    }
}
