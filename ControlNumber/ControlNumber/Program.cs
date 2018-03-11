using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int numN = 1;
            int numM = m;
            int counterMoves = 0;

            while (numN <= n)
            {
                while (numM >= 1)
                {
                    sum += numN * 2 + numM * 3;
                    numM--;
                    counterMoves++;
                    if (sum >= controlNumber)
                        break;
                }
                numN++;
                numM = m;
                if (sum >= controlNumber)
                    break;
            }
            if (sum >= controlNumber)
            {
                Console.WriteLine($"{counterMoves} moves");
                Console.WriteLine($"Score: {sum} >= {controlNumber}");
            }
            else
            {
                Console.WriteLine($"{counterMoves} moves");
            }
        }
    }
}
