namespace Herança.Entities
{
    // Classe Account, representa uma conta bancária genérica
    class Account
    {
        // Propriedades: Número da conta, titular e saldo
        public int Number { get; private set; }   // Propriedade somente leitura externa
        public string Holder { get; private set; } // Propriedade somente leitura externa
        public double Balance { get; protected set; } // Propriedade protegida para ser acessada por subclasses

        // Construtor padrão
        public Account()
        {
        }

        // Construtor com parâmetros para inicializar os atributos
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Método para saque, subtrai o valor do saldo
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        // Método para depósito, adiciona o valor ao saldo
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
