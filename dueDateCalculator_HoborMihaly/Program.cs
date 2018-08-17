using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dueDateCalculator_HoborMihaly
{
    class Program
    {
        static void Main(string[] args)
        {



            

            Console.WriteLine("Adj meg egy bug desct!");
            string desc = Console.ReadLine();
            Console.WriteLine("Add meg mennyi ido van ra! NAP ORA PERC (max 60) formatumban");
            string[] time = Console.ReadLine().Split(' ');

            int days = Convert.ToInt32(time[0]);
            int hours = Convert.ToInt32(time[1]);
            int minutes = Convert.ToInt32(time[2]);

            BugHandler.AddBug(days,hours,minutes, desc);

            Console.ReadLine();


        }
    }
}
