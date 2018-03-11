using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FirstAndSecondLine(n);
            MainBody(n);
            FirstAndSecondLine(n);
        }

        static void FirstAndSecondLine(int n)
        {
            Console.WriteLine("{0}", new string('-', 2 * n));
        }

        static void MainBody(int n)
        {
            for (int i = 2; i <= n - 1; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
