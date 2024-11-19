namespace MembrosEstaticos
{
    internal class Calculadora
    {
        // Declaração de uma variável estática para armazenar o valor de Pi
        public static double Pi = 3.14;

        // Método estático para calcular a circunferência de um círculo
        public static double Circunferencia(double r)
        {
            // Retorna o valor da circunferência usando a fórmula 2 * Pi * raio
            return 2.0 * Pi * r;
        }

        // Método estático para calcular o volume de uma esfera
        public static double Volume(double r)
        {
            // Retorna o valor do volume usando a fórmula 4/3 * Pi * raio³
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
