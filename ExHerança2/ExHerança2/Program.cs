using ExHerança2.Entities;
using System.Globalization;

namespace ExHerança2
{

    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de produtos que armazenará todos os tipos de produtos
            List<Product> productList = new List<Product>();

            // Solicita ao usuário o número de produtos a serem registrados
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            // Laço de repetição para registrar N produtos
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                // Pergunta ao usuário qual tipo de produto (Comum, Usado ou Importado)
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                // Coleta as informações comuns a todos os produtos: nome e preço
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Se o produto for importado, solicita a taxa alfandegária e cria um produto importado
                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productList.Add(new ImportedProduct(name, price, customsFee));
                }
                // Se o produto for usado, solicita a data de fabricação e cria um produto usado
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    productList.Add(new UsedProduct(name, price, manufactureDate));
                }
                // Caso contrário, cria um produto comum
                else
                {
                    productList.Add(new Product(name, price));
                }
            }

            // Exibe as etiquetas de preço de cada produto
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in productList)
            {
                // Chama o método PriceTag de cada produto para exibir as informações
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}

