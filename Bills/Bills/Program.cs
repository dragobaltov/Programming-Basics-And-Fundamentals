using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int water = 20 * months;
            int internet = 15 * months;
            double electricityForMonths = 0.0;
            double others = 0.0;

            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                others = others + (15 + 20 + electricity) * 1.2;
                electricityForMonths += electricity;
            }
            //double others = (electricityForMonths + water + internet) * 0.2 * months;

            Console.WriteLine($"Electricity: {electricityForMonths:F2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {others:F2} lv");
            Console.WriteLine($"Average: {(electricityForMonths + water + internet + others) / months:F2} lv");
        }
    }
}
