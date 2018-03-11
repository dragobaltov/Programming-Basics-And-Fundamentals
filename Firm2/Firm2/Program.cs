using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workersBonusTime = int.Parse(Console.ReadLine());
            double daysAvailable = days * 0.9;
            double hours = daysAvailable * 8;
            double bonusHours = workersBonusTime * 2 * days;
            double hoursAtAll = Math.Floor(hours + bonusHours);

            if (hoursAtAll >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{hoursAtAll - hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded - hoursAtAll} hours needed.");
            }
        }
    }
}
