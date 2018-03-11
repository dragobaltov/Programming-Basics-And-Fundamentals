using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            //a e i o u
            //1 2 3 4 5
            string text = Console.ReadLine();
            double sum = 0.0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sum += 1;
                }
                else if (text[i] == 'e')
                {
                    sum += 2;
                }
                else if (text[i] == 'i')
                {
                    sum += 3;
                }
                else if (text[i] == 'o')
                {
                    sum += 4;
                }
                else if (text[i] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
