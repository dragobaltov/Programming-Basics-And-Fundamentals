using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills2
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double water = 20;
            double internet = 15;
            double electricityAtAll = 0;
            double othersAtAll = 0;
            double waterAtAll = months * water;
            double internetAtAll = internet * months;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                double others = (electricity + internet + water) * 1.2;
                electricityAtAll += electricity;
                othersAtAll += others;
            }

            double average = (waterAtAll + internetAtAll + electricityAtAll + othersAtAll) / months;

            Console.WriteLine($"Electricity: {electricityAtAll:F2} lv");
            Console.WriteLine($"Water: {waterAtAll:F2} lv");
            Console.WriteLine($"Internet: {internetAtAll:F2} lv");
            Console.WriteLine($"Other: {othersAtAll:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
