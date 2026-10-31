using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static שיעור_מס_3.Program;

namespace שיעור_מס_3
{
    
    internal class SmartPot
    {
        public event kitchen onDishReady;
        public void StartCooking(string dish, int minutes)
        {
            
            for (int i = 0; i < minutes; i++)
            {
                Console.WriteLine("עברה דקה מזמן הבישול");
            }
            Console.WriteLine("זמן הבישול הסתיים");
            onDishReady?.Invoke(dish, minutes);

        }
    }
}
