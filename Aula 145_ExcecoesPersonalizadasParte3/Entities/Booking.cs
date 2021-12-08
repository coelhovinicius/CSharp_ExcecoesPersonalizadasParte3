/* >>> CLASSE BOOKING <<< */
using System;
using Aula_145_ExcecoesPersonalizadasParte3.Entities.Exceptions;

namespace Aula_145_ExcecoesPersonalizadasParte3.Entities
{
    class Booking
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Booking()
        {
        }

        public Booking(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Booking error: Check-out date must be later than check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; // Casting do double TotalDays para inteiro
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("Rebooking error: Dates must be later than today"); // Lanca uma nova instancia da Excecao
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Booking error: Check-out date must be later than check-in date"); 
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber
                + ", check-in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: " + CheckOut.ToString("dd/MM/yyyy")
                + ", " + Duration() + " nights";
        }
    }
}
