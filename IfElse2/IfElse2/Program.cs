using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            if(fruit == "Bannana")
            {
                Console.WriteLine("The colour is yellow");
            }
            else if(fruit == "Apple")
            {
                Console.WriteLine("The colour is red, yellow or green");
            }
            else if(fruit == "Watermelon")
            {
                Console.WriteLine("The colour is green");
            }
            else
            {
                Console.WriteLine("This isn't a fruit");
            }
        }
    }
}
