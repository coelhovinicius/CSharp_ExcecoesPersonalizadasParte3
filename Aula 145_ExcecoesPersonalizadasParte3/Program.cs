/* EXCECOES PERSONALIZADAS - SOLUCAO CORRETA */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula_145_ExcecoesPersonalizadasParte3.Entities;
using Aula_145_ExcecoesPersonalizadasParte3.Entities.Exceptions;

namespace Aula_145_ExcecoesPersonalizadasParte3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Booking booking = new Booking(roomNumber, checkIn, checkOut);
                Console.WriteLine("Booking: " + booking);

                Console.WriteLine();
                Console.WriteLine("Enter new dates for rebooking: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                booking.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Booking: " + booking);
            }

            catch (DomainException e)
            {
                Console.WriteLine("Booking error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error! " + e.Message);
            }
        }
    }
}

