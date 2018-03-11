using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool2
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pipe1ForH = pipe1 * hours;
            double pipe2ForH = pipe2 * hours;
            double all = pipe1ForH + pipe2ForH;

            if (all <= V)
            {
                Console.WriteLine($"The pool is {Math.Floor(all / V * 100)}% full. Pipe 1: {Math.Floor(pipe1ForH / all * 100)}%. Pipe 2: {Math.Floor(pipe2ForH / all * 100)}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {all - V:F1} liters.");
            }
        }
    }
}
