using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague2
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityStadium = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            double sectionA = 0;
            double sectionB = 0;
            double sectionV = 0;
            double sectionG = 0;


            for (int i = 0; i < fans; i++)
            {
                string section = Console.ReadLine();
                if (section == "A")
                {
                    sectionA++;
                }
                else if (section == "B")
                {
                    sectionB++;
                }
                else if (section == "V")
                {
                    sectionV++;
                }
                else if (section == "G")
                {
                    sectionG++;
                }
            }

            Console.WriteLine($"{sectionA / fans * 100:F2}%");
            Console.WriteLine($"{sectionB / fans * 100:F2}%");
            Console.WriteLine($"{sectionV / fans * 100:F2}%");
            Console.WriteLine($"{sectionG / fans * 100:F2}%");
            Console.WriteLine($"{fans * 1.0 / capacityStadium * 100:F2}%");
        }
    }
}
