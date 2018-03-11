using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numbersForSkipping = array[0];
            int numbersForTaking = array[1];
            var newArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < newArray.Count; i++)
            {
                if (newArray[i] < 65 || newArray[i] > 90)
                {
                    newArray.RemoveAt(i);
                    i--;
                }
            }
            newArray = newArray.Skip(numbersForSkipping).Take(numbersForTaking).ToList();

            for (int i = 0; i < newArray.Count; i++)
            {
                if (newArray[i] >= 65 && newArray[i] <= 90)
                {
                    Console.Write((char)newArray[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
