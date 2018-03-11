using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
            {
                Console.WriteLine("{0}", new string('*', n));
            }
            else
            {
                if (n % 2 == 0)
                {
                    int endLineCounter = (n - 4) / 2;
                    int midlineCounter = 2;
                    for (int i = 1; i <= n / 2; i++)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 2));
                        }
                        else
                        {
                            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', endLineCounter), new string('*', 1), new string('-', midlineCounter));
                            endLineCounter--;
                            midlineCounter += 2;
                        }
                    }
                    int endLineCounter2 = 1;
                    int midlineCounter2 = n - 4;
                    for (int i = n / 2 + 1; i <= n - 1; i++)
                    {
                        if (i == n - 1)
                        {
                            Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 2));
                        }
                        else
                        {
                            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', endLineCounter2), new string('*', 1), new string('-', midlineCounter2));
                            endLineCounter2++;
                            midlineCounter2 -= 2;
                        }
                    }
                }
                else
                {
                    int endLineCounter = (n - 3) / 2;
                    int midlineCounter = 1;
                    for (int i = 1; i <= n / 2 + 1; i++)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 1));
                        }
                        else
                        {
                            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', endLineCounter), new string('*', 1), new string('-', midlineCounter));
                            endLineCounter--;
                            midlineCounter += 2;
                        }
                    }
                    int endLineCounter2 = 1;
                    int midlineCounter2 = n - 4;
                    for (int i = n / 2 + 1; i <= n - 1; i++)
                    {
                        if (i == n - 1)
                        {
                            Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', 1));
                        }
                        else
                        {
                            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', endLineCounter2), new string('*', 1), new string('-', midlineCounter2));
                            endLineCounter2++;
                            midlineCounter2 -= 2;
                        }
                    }
                }
            }
        }
    }
}
