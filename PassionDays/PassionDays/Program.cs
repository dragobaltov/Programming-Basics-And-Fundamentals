using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string command = "mall.Enter";

            Console.WriteLine(command);
            while (command != "mall.Exit")
            {
                char symbol = char.Parse(Console.ReadLine());
                int symbol2 = Convert.ToInt16(symbol);
                if (symbol2 >= 97 && symbol2 <= 122)
                {
                    money -= 0.3 * symbol2;
                    if (money <= 0)
                        break;
                }
                else if (symbol2 >= 65 && symbol2 <= 90)
                {
                    money -= 0.5 * symbol2;
                    if (money <= 0)
                        break;
                }
                else if (symbol2 == 37)
                {
                    money /= 2;
                }
                else if (symbol2 == 42)
                {
                    money += 10;
                }
                else
                {
                    money -= symbol2;
                    if (money <= 0)
                        break;
                }
            }
            Console.WriteLine(command);
        }
    }
}
