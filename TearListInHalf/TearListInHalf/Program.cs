using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> firstPart = new List<int>();
            List<int> secondPart = new List<int>();
            List<int> newList = new List<int>();

            CreatingFirstPart(initialList, firstPart);
            CreatingSecondPart(initialList, secondPart);

            for (int i = 0; i < firstPart.Count; i++)
            {
                int secondDigit = secondPart[i] % 10;
                int firstDigit = (secondPart[i] - secondDigit) / 10;

                newList.Add(firstDigit);
                newList.Add(firstPart[i]);
                newList.Add(secondDigit);
            }

            Console.WriteLine(string.Join(" ", newList));
        }

        static void CreatingFirstPart(List<int> initialList, List<int> firstPart)
        {
            for (int i = 0; i < initialList.Count / 2; i++)
            {
                firstPart.Add(initialList[i]);
            }
        }

        static void CreatingSecondPart(List<int> initialList, List<int> secondPart)
        {
            for (int i = initialList.Count / 2; i < initialList.Count; i++)
            {
                secondPart.Add(initialList[i]);
            }
        }
    }
}
