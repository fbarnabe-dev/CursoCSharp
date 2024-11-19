namespace StremWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Visual Studio Community\File1.txt";
            string targetPath = @"D:\Visual Studio Community\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
