using MulticastEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCTCBOOKING
{
    public class IRCTCBooking
    {
        //public delegate void SendNotification(string username);
        public static T BookTicket<T>(Func<T, T> func, T obj) where T : class
        {
            Console.WriteLine("Booking Confirmed");
            //Log
            T temp = func(obj);
            return temp;
        }

        
    }


}
