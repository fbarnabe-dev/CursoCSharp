using ProcessFile.Entities;

namespace ProcessFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do número do quarto
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());

            // Entrada das datas de check-in e check-out
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            // Validação para garantir que a data de check-out seja posterior à de check-in
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                // Cria uma reserva se as datas forem válidas
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                // Entrada para atualização das datas da reserva
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd//MM//yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                // Validações para garantir que as datas de atualização sejam no futuro e que check-out seja após o check-in
                DateTime now = DateTime.Now;
                if (checkIn <= now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation date for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    // Atualiza as datas se forem válidas
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
