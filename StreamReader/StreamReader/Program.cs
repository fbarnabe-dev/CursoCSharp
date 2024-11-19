using System.IO;

namespace StremReader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"D:\Visual Studio Community\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}