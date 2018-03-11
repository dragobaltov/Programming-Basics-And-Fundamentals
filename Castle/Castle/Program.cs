using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string top = new string('^', n / 2);
            string bottom = new string('_', n / 2);
            string space = new string(' ', 2 * n - 2);
            string line = "";
            string spaceBottom = "";
            if (n > 4)
            {
                line = new string('_', n - 4);
                spaceBottom = new string('_', n - 4);
            }
            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    Console.Write("/");
                    Console.Write(top);
                    Console.Write("\\");
                    Console.Write(line);
                    Console.Write("/");
                    Console.Write(top);
                    Console.WriteLine("\\");
                }
                Console.Write('|');
                Console.Write(space);
                Console.WriteLine('|');
                if (row == n - 1)
                {
                    Console.Write('|');
                    Console.Write(new string(' ', (2*n - 2 - line.Length) / 2));
                    Console.WriteLine(line);
                    Console.Write(new string(' ', (2 * n - 2 - line.Length) / 2));
                    Console.WriteLine('|');
                }
                if (row == n)
                {
                    Console.Write("\\");
                    Console.Write(bottom);
                    Console.Write("/");
                    Console.Write(spaceBottom);
                    Console.Write("/");
                    Console.Write(top);
                    Console.WriteLine("/");
                }
            }
        }
    }
}
