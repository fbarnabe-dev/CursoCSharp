namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Segunda";
                    break;
                case 2:
                    day = "Terça";
                    break;
                case 3:
                    day = "Quarta";
                    break;
                case 4:
                    day = "Quinta";
                    break;
                case 5:
                    day = "Sexta";
                    break;
                case 6:
                    day = "Sabado";
                    break;
                case 7:
                    day = "Domingo";
                    break;
                default:
                    day = "Valor invalido";
                    break;
            }

            Console.WriteLine("Dia escolhido: " + day);
        }
    }
}
