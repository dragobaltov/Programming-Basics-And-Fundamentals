using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = null;
            int counterIngredients = 0;

            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                    break;
                counterIngredients++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
            Console.WriteLine($"Preparing cake with {counterIngredients} ingredients.");
        }
    }
}
