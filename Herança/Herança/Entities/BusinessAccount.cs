

namespace Herança.Entities    
{
    // Declaração da classe BusinessAccount, que herda da classe Account
    class BusinessAccount : Account
    {
        // Propriedade pública para o limite de empréstimo (LoanLimit)
        public double LoanLimit { get; set; }

        // Construtor padrão sem parâmetros
        public BusinessAccount()
        {
        }

        // Construtor que aceita parâmetros e chama o construtor da classe base Account
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)    // Chama o construtor da classe Account
        {
            LoanLimit = loanLimit;    // Define o valor do limite de empréstimo
        }

        // Método Loan para realizar empréstimo, aumentando o saldo se o valor for menor ou igual ao limite
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)  // Verifica se o valor solicitado está dentro do limite
            {
                Balance += amount;    // Adiciona o valor ao saldo se a condição for atendida
            }
        }
    }
}
