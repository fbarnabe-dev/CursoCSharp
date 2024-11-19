namespace ProcessFile.Entities
{
    internal class Reservation
    {
        // Propriedade para armazenar o número do quarto
        public int RoomNumber { get; set; }

        // Propriedades para armazenar as datas de check-in e check-out
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        // Construtor padrão sem argumentos
        public Reservation()
        {
        }

        // Construtor que inicializa a reserva com número do quarto e datas
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber; 
            CheckIn = checkIn;       
            CheckOut = checkOut;     
        }

        // Método que calcula a duração da estadia em dias
        public int Duration()
        {
            // Calcula a diferença entre a data de check-out e check-in
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; 
        }

        // Método para atualizar as datas de check-in e check-out
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;   
            CheckOut = checkOut; 
        }

        // Método que retorna uma representação de string da reserva
        public override string ToString()
        {
            return "Room "
            + RoomNumber 
            + ", check-in: "
            + CheckIn.ToString("dd/MM/yyyy") 
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy") 
            + ", "
            + Duration() 
            + " nights";
        }
    }
}
