using System;
using System.IO;

namespace Exemplos_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Visual Studio Community\File1.txt";
            string targetPath = @"D:\Visual Studio Community\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}