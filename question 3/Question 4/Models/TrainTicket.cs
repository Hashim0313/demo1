using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4.Models
{
    public class TrainTicket : Ticket
    {
        public TrainTicket(int ticketid, string passengername) : base(ticketid, passengername)
        {

        }

        public void CalculateFare(int distance)
        {
            double ticketprice = distance * 0.5;

            Console.WriteLine($"Train \n\n ticket id : {TicketId} \n passenger name : {PassengerName} \n distance : {distance} \n ticket price : {ticketprice}");
        }
    }
}
