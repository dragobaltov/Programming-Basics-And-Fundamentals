using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textCoordinates = Console.ReadLine().Split(' ');
            int[] coordinatesOfTarget = new int[textCoordinates.Length];
            for (int i = 0; i < 2; i++)
            {
                coordinatesOfTarget[i] = int.Parse(textCoordinates[i]);
            }

            string[] commands = Console.ReadLine().Split(' ');
            long x = 0;
            long y = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    y += Convert.ToInt64(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    y-= Convert.ToInt64(commands[i + 1]);
                }
                else if (commands[i] == "right")
                {
                    x += Convert.ToInt64(commands[i + 1]);
                }
                else if (commands[i] == "left")
                {
                    x-= Convert.ToInt64(commands[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{x}, {y}]");
            if (coordinatesOfTarget[0] == x && coordinatesOfTarget[1] == y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
