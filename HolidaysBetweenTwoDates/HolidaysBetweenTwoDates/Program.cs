using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.m.yyyy", CultureInfo.InvariantCulture);
            int holidaysCounter = 0;
            var dayOfStart = startDate.DayOfWeek;
            var dayOfEnd = endDate.DayOfWeek

            for (var date = startDate; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCounter++;
                }
            }
            
            Console.WriteLine(holidaysCounter);
        }
    }
}
