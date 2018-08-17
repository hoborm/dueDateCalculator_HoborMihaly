using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dueDateCalculator_HoborMihaly
{
   public class Bug
    {
        static int count = 0;
        int id;
        DateTime bugRegisterTime;
        DateTime dueDate;
        //DateTime turnaround;
        string bugDescription;
        bool done=false;
        int days, hours, minutes;



        public DateTime BugRegisterTime
        {
            get
            {
                return bugRegisterTime;
            }
            internal set
            {
                this.bugRegisterTime = value;
            }
        }

        //public DateTime TurnAround
        //{
        //    get
        //    {
        //        return turnaround;
        //    }

        //    internal set
        //    {
        //        this.turnaround = value;
        //    }
        //}

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }
        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }
        public int Id
        {
            get { return id; }
            private set { }
        }

        public int Days { get => days; set => days = value; }
        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }

        public Bug(DateTime bugRegisterTime, int days, int hours, int minutes, string bugDescription)
        {
            this.bugRegisterTime = bugRegisterTime;
            this.Days = days;
            this.Hours = hours;
            this.Minutes = minutes;
            this.bugDescription = bugDescription;
            id = count + 1;


        }
    }
}
