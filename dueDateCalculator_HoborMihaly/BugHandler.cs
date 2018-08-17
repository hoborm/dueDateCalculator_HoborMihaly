using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dueDateCalculator_HoborMihaly
{
   public static class BugHandler
    {
        static List<Bug> bugs = new List<Bug>();
         


        public static void AddBug(int days, int hours, int minutes, string bugDescription)
        {
            Bug bug = new Bug(new DateTime(2018, 08, 16, 15, 45, 12), days, hours, minutes, bugDescription); //2018.08.16 12:45 perces datummal vesszuk fel a bugot, termeszetesen a live verzioban a DateTime.Now propertyt hasznalnam
            bugs.Add(bug);
            Schedule(bug);
        }

        public static void Schedule(Bug bug)
        {
            bug.DueDate = DateTimeExtensions.AddInBusinessDays(bug.BugRegisterTime,bug.Days,bug.Hours,bug.Minutes);

            Console.WriteLine("A bugot a {0} napig kell megcsinalni", bug.DueDate);

        }

        public static void MarkedAsDone(Bug bug) //tovabbi kiegeszites lehetosege, hogy kezeljuk a bugokat
        {
            if (bugs.Contains(bug))
            {
                bug.Done = true;
            }
        }
    }

}
