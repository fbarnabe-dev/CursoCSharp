using Herança.Entities;          // Importa o namespace Herança.Entities, que provavelmente contém a classe BusinessAccount

namespace Herança               
{
    class Program               
    {
        static void Main(string[] args)   // Método principal que é o ponto de entrada do programa
        {
            // Cria uma nova instância de BusinessAccount, passando os parâmetros da conta:
            // número da conta 8010, nome "Felipe Barnabé", saldo inicial 100.0 e limite de crédito 500.0
            BusinessAccount account = new BusinessAccount(8010, "Felipe Barnabé", 100.0, 500.0);

            // Exibe o saldo da conta no console
            Console.WriteLine(account.Balance);
        }
    }
}

