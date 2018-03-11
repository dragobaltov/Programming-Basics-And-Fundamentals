using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint questions = uint.Parse(Console.ReadLine());
            uint aCounter = 0;
            uint bCounter = 0;
            uint cCounter = 0;
            uint dCounter = 0;
            string result = null;

            for (int i = 1; i <= questions; i++)
            {
                uint numQuestion = uint.Parse(Console.ReadLine());
                if (numQuestion % 4 == 0)
                {
                    aCounter++;
                    result += "a ";
                }
                else if (numQuestion % 4 == 1)
                {
                    bCounter++;
                    result += "b ";
                }
                else if (numQuestion % 4 == 2)
                {
                    cCounter++;
                    result += "c ";
                }
                else if (numQuestion % 4 == 3)
                {
                    dCounter++;
                    result += "d ";
                }
            }
            Console.WriteLine(result);
            Console.WriteLine($"Answer A: {aCounter}");
            Console.WriteLine($"Answer B: {bCounter}");
            Console.WriteLine($"Answer C: {cCounter}");
            Console.WriteLine($"Answer D: {dCounter}");
        }
    }
}
