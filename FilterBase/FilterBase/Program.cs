using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split
                (new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> nameAge = new Dictionary<string, int>();
            Dictionary<string, double> nameSalary = new Dictionary<string, double>();
            Dictionary<string, string> namePosition = new Dictionary<string, string>();

            while (input[0] != "filter")
            {
                string name = input[0];
                string anotherInfo = input[1];
                int age; double salary; string position;

                if (int.TryParse(anotherInfo, out age))
                {
                    nameAge.Add(name, age);
                }
                else if (double.TryParse(anotherInfo, out salary))
                {
                    nameSalary.Add(name, salary);
                }
                else
                {
                    position = anotherInfo;
                    namePosition.Add(name, position);
                }

                input = Console.ReadLine().Split
                (new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string neededInfo = Console.ReadLine();
            string divider = new string('=', 20);

            if (neededInfo == "Age")
            {
                foreach (var item in nameAge)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(divider);
                }
            }
            else if (neededInfo == "Salary")
            {
                foreach (var item in nameSalary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:F2}");
                    Console.WriteLine(divider);
                }
            }
            else
            {
                foreach (var item in namePosition)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(divider);
                }
            }
        }
    }
}
