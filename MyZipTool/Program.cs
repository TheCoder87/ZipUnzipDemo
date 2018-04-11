using System;
using System.IO.Compression;

namespace MyZipTool
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string operation = args[0];

                switch (operation)
                {
                    case "-z":
                    case "-Z":
                        ZipFromDirectory(args);
                        break;
                    case "-u":
                    case "-U":
                        UnZipToDirectory(args);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private static void ZipFromDirectory(string[] args)
        {
            ZipFile.CreateFromDirectory(args[1], args[2]);
        }

        private static void UnZipToDirectory(string[] args)
        {
            ZipFile.ExtractToDirectory(args[1], args[2]);
        }

    }
}
