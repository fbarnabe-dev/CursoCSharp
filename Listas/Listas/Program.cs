namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Felipe");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Add("Reginaldo");
            list.Insert(2, "Nadir");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }
            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'F');
            Console.WriteLine("First 'F': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'R');
            Console.WriteLine("First position 'R': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'R');
            Console.WriteLine("Last position 'R': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Felipe");
            Console.WriteLine("--------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'R');
            Console.WriteLine("--------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}