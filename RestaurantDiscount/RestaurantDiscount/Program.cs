using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();
            string hallName = null;
            double pricePerPerson = 0;
            bool no = false;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                if (servicePackage == "Normal")
                {
                    pricePerPerson = ((2500 + 500) * 0.95) / groupSize;
                }
                else if (servicePackage == "Gold")
                {
                    pricePerPerson = ((2500 + 750) * 0.9) / groupSize;
                }
                else if (servicePackage == "Platinum")
                {
                    pricePerPerson = ((2500 + 1000) * 0.85) / groupSize;
                }
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                if (servicePackage == "Normal")
                {
                    pricePerPerson = ((5000 + 500) * 0.95) / groupSize;
                }
                else if (servicePackage == "Gold")
                {
                    pricePerPerson = ((5000 + 750) * 0.9) / groupSize;
                }
                else if (servicePackage == "Platinum")
                {
                    pricePerPerson = ((5000 + 1000) * 0.85) / groupSize;
                }
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                if (servicePackage == "Normal")
                {
                    pricePerPerson = ((7500 + 500) * 0.95) / groupSize;
                }
                else if (servicePackage == "Gold")
                {
                    pricePerPerson = ((7500 + 750) * 0.9) / groupSize;
                }
                else if (servicePackage == "Platinum")
                {
                    pricePerPerson = ((7500 + 1000) * 0.85) / groupSize;
                }
            }
            else
            {
                no = true;
            }

            if (no == true)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
