namespace ExHerança.Entities
{
    // A classe OutsourcedEmployee herda da classe Employee
    internal class OutsourcedEmployee : Employee
    {
        // Propriedade que armazena a cobrança adicional para o funcionário terceirizado
        public double AdditionalCharge { get; set; }

        // Construtor padrão vazio
        public OutsourcedEmployee()
        {
        }

        // Construtor que recebe nome, horas, valor por hora e a cobrança adicional
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)  // Chama o construtor da classe base (Employee)
        {
            AdditionalCharge = additionalCharge;
        }

        // Sobrescreve o método Payment() da classe Employee
        public override double Payment()
        {
            // Calcula o pagamento base mais 110% da cobrança adicional
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
