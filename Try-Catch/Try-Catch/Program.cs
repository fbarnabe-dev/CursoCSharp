namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // Lê dois números inteiros da entrada do usuário.
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                // Realiza a divisão dos dois números.
                int result = n1 / n2;

                // Exibe o resultado da divisão.
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                // Trata a exceção se o segundo número for zero (não permite divisão por zero).
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                // Trata a exceção se o usuário fornecer uma entrada com formato inválido (não numérico).
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}


