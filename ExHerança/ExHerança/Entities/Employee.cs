namespace ExHerança.Entities
{
    // Definição da classe Employee, representando um funcionário
    internal class Employee
    {
        // Propriedades: Nome, Horas trabalhadas, Valor por hora
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        // Construtor padrão (vazio)
        public Employee()
        {
        }

        // Construtor que inicializa as propriedades Name, Hours e ValuePerHour
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Método virtual para calcular o pagamento do funcionário
        // Pode ser sobrescrito por classes derivadas
        public virtual double Payment()
        {
            return Hours * ValuePerHour;  // Calcula o pagamento com base nas horas e no valor por hora
        }
    }
}
