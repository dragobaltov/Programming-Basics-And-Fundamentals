using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] integers = Console.ReadLine().Split(' ');
            int[] intArr = new int[integers.Length];
            int asciiCode = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(integers[i]);
                asciiCode = text[i];
            
                if (intArr[i] % 2 == 0)
                {
                    asciiCode -= intArr[i];
                }
                else
                {
                    asciiCode += intArr[i];
                }

                Console.Write((char)asciiCode);
            }
            Console.WriteLine();
        }
    }
}
