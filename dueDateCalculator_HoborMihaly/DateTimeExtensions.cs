using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dueDateCalculator_HoborMihaly
{
    public static class DateTimeExtensions
    {

        public static DateTime AddInBusinessDays(DateTime from, int days, int hours, int minutes)
        {
            DateTime due = from;

            AddMinutes(ref due, minutes);
            AddHours(ref due, hours);
            AddDays(ref due, days);


            return due;
            }

        public static void AddMinutes(ref DateTime from, int amount) //a percek hozzaadasaert felelos metodus
        {
        

            if (from.Minute+amount>60)
            {
              AddHours(ref from, 1);
             from=from.AddMinutes(from.Minute+amount-60);
            }
            else
            {
               from=from.AddMinutes(amount);
            }
        }

        public static void AddHours(ref DateTime from, int amount) //az orak hozzaadasaert felelos metodus
        {
            if (from.Hour+amount>17 )
            {

                while (amount>0)
                {
                    AddDays(ref from, 1);
                    
                    amount -= 8;
                }
                from = from.AddHours(amount );
            }
            else
            {
                from=from.AddHours(amount);
            }
        }

        public static void AddDays(ref DateTime from,int amount) //ez kezeli a napok hozzaadasat mivel munkanapokon dolgozunk
        {
            while(amount!=0)
            {
                amount--;
                if (from.DayOfWeek==DayOfWeek.Friday)
                {
                    from=from.AddDays(3);
                }
                else
                {
                    from=from.AddDays(1);
                }
            }
        }



        }



    }

