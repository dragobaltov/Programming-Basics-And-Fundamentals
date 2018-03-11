using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string messege = String.Empty;
            string previousString = String.Empty;
            bool direction = false;

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString == previousString)
                {
                    if (currentString == "spin")
                    {
                        i--;
                        messege = null;
                    }
                    else
                    {
                        messege = null;
                    }
                }
                else
                {
                    if (currentString == "spin")
                    {
                        direction = !direction;
                        i--;
                    }
                    else
                    {
                        if (direction)
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
