using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());
            int hoursWorked = workDays * 8 * workers;

            if (hoursWorked >= hours)
            {
                Console.WriteLine($"{hoursWorked - hours} hours left");
            }
            else
            {
                Console.WriteLine($"{hours - hoursWorked} overtime");
                Console.WriteLine($"Penalties: {workDays * (hours - hoursWorked)}");
            }
        }
    }
}
