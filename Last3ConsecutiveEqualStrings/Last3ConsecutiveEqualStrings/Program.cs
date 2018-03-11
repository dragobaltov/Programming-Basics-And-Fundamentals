using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            string consecutiveElement = String.Empty;
            bool consecutiveStrings = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 2)
                    break;
                
                if (array[i] == array[i + 1] && array[i + 1] == array[i + 2])
                {
                    consecutiveStrings = true;
                    consecutiveElement = array[i];
                }
            }

            if (consecutiveStrings == true)
            {
                Console.WriteLine("{0} {0} {0}", consecutiveElement);
            }
        }
    }
}
