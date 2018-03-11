using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());
            int hoursWorked = 8 * workDays * workers;

            if (hoursWorked >= hoursNeeded)
            {
                Console.WriteLine($"{hoursWorked - hoursNeeded} hours left");
            }
            else
            {
                Console.WriteLine($"{hoursNeeded - hoursWorked} overtime");
                Console.WriteLine($"Penalties: {(hoursNeeded - hoursWorked) * workDays}");
            }
        }
    }
}
