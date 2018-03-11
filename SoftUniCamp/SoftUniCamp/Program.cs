using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;
            for (int i = 0; i < groups; i++)
            {
                int peopleInAGroup = int.Parse(Console.ReadLine());
                if (peopleInAGroup <= 5)
                {
                    group1 += peopleInAGroup;
                }
                else if (peopleInAGroup >= 6 && peopleInAGroup <= 12)
                {
                    group2 += peopleInAGroup;
                }
                else if (peopleInAGroup >= 13 && peopleInAGroup <= 25)
                {
                    group3 += peopleInAGroup;
                }
                else if (peopleInAGroup >= 26 && peopleInAGroup <= 40)
                {
                    group4 += peopleInAGroup;
                }
                else if (peopleInAGroup >= 41)
                {
                    group5 += peopleInAGroup;
                }
            }
            double allPeople = group1 + group2 + group3 + group4 + group5;
            Console.WriteLine($"{group1 / allPeople * 100:F2}%");
            Console.WriteLine($"{group2 / allPeople * 100:F2}%");
            Console.WriteLine($"{group3 / allPeople * 100:F2}%");
            Console.WriteLine($"{group4 / allPeople * 100:F2}%");
            Console.WriteLine($"{group5 / allPeople * 100:F2}%");
        }
    }
}
