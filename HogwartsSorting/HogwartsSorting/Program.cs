using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogwartsSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var housesData = new Dictionary<string, int>();
            housesData.Add("Gryffindor", 0);
            housesData.Add("Slytherin", 0);
            housesData.Add("Ravenclaw", 0);
            housesData.Add("Hufflepuff", 0);

            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstName = names[0];
                string secondName = names[1];
                int sum = 0;

                for (int j = 0; j < firstName.Length; j++)
                {
                    sum += firstName[j];
                }
                for (int j = 0; j < secondName.Length; j++)
                {
                    sum += secondName[j];
                }

                if (sum % 4 == 0)
                {
                    Console.WriteLine("Gryffindor " + sum + firstName[0] + secondName[0]);
                    housesData["Gryffindor"]++;
                }
                else if (sum % 4 == 1)
                {
                    Console.WriteLine("Slytherin " + sum + firstName[0] + secondName[0]);
                    housesData["Slytherin"]++;
                }
                else if (sum % 4 == 2)
                {
                    Console.WriteLine("Ravenclaw " + sum + firstName[0] + secondName[0]);
                    housesData["Ravenclaw"]++;
                }
                else
                {
                    Console.WriteLine("Hufflepuff " + sum + firstName[0] + secondName[0]);
                    housesData["Hufflepuff"]++;
                }
            }
            Console.WriteLine();

            foreach (var item in housesData)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
