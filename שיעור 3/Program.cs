using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace שיעור_מס_3
{
    internal class Program
    {
        public delegate void kitchen(string name, int min);
        
        static void Main(string[] args)
        {
           SmartPot sp = new SmartPot();
           Chef cf = new Chef();
           sp.onDishReady+=cf.TakeOffStove;
            sp.onDishReady+=(dish, minutes) => Console.WriteLine("צפצוף אזהרה");
           sp.StartCooking("עוף",8);
            sp.onDishReady-=cf.TakeOffStove;
            sp.StartCooking("מרק", 8);
        }
    }
}
