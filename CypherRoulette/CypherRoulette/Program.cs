using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string messege = String.Empty;
            string currentString = String.Empty;
            string previousString = String.Empty;
            bool reverse = false;

            for (int i = 1; i <= n; i++)
            {
                currentString = Console.ReadLine();

                if (currentString == previousString)
                {
                    messege = String.Empty;
                    if (currentString == "spin")
                    {
                        n++;
                    }
                }
                else
                {
                    if (currentString == "spin")
                    {
                        reverse = !reverse;
                        n++;
                    }
                    else
                    {
                        if (reverse)
                        {
                            messege = currentString + messege;
                        }
                        else
                        {
                            messege = messege + currentString;
                        }
                    }
                }

                previousString = currentString;
            }

            Console.WriteLine(messege);
        }
    }
}
