using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (month == 11)
                {
                    if (day <= 25)
                    {
                        Console.WriteLine($"{day + 5}.{month}");
                    }
                    else
                    {
                        Console.WriteLine($"{day + 5 - 30}.{month + 1}");
                    }
                }
                else
                {
                    if (day <= 25)
                    {
                        Console.WriteLine($"{day + 5}.0{month}");
                    }
                    else
                    {
                        if (month == 9)
                        {
                            Console.WriteLine($"{day + 5 - 30}.{month + 1}");
                        }
                        else
                        {
                            Console.WriteLine($"{day + 5 - 30}.0{month + 1}");
                        }
                    }
                }
            }
            else if (month == 2)
            {
                if (day <= 23)
                {
                    Console.WriteLine($"{day + 5}.0{month}");
                }
                else
                {
                    Console.WriteLine($"{day + 5 - 28}.0{month + 1}");
                }
            }
            else
            {
                if (month <= 8)
                {
                    if (day <= 26)
                    {
                        Console.WriteLine($"{day + 5}.0{month}");
                    }
                    else
                    {
                        Console.WriteLine($"{day + 5}.0{month + 1}");
                    }
                }
                else if (month == 12)
                {
                    if (day <= 26)
                    {
                        Console.WriteLine($"{day + 5}.{month}");
                    }
                    else
                    {
                        Console.WriteLine($"{day + 5 - 31}.01");
                    }
                }
                else
                {
                    if (day <= 26)
                    {
                        Console.WriteLine($"{day + 5}.{month}");
                    }
                    else
                    {
                        Console.WriteLine($"{day + 5 - 31}.{month + 1}");
                    }
                }
            }
        }
    }
}
