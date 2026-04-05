using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4.Models
{
    public class BusTicket : Ticket
    {
        public BusTicket (int TicketId,string PassengerName) : base (TicketId,PassengerName)
        {

        }

        public void CalculateFare(int distance)
        {
            double ticketprice = distance * 1;

            Console.WriteLine($"\n\nBus\n\n ticket id : {TicketId} \n passenger name : {PassengerName} \n distance : {distance} \n ticket price : {ticketprice}");

        }
    }
}
