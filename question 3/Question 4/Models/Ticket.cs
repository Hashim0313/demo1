using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4.Models
{
    public class Ticket
    {
        public int TicketId;
        public string PassengerName;

        public Ticket (int ticketid, string passengername)
        {
            TicketId = ticketid;
            PassengerName = passengername;
        }

        public void CalculateFare(int distance)
        {

        }
    }
}
