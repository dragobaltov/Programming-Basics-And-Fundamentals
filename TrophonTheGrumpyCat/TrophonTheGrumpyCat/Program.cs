using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrophonTheGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItemsToBeBroken = Console.ReadLine();
            string typeOfPriceRatingsSearched = Console.ReadLine();

            int entryPointPriceRating = priceRatings[entryPoint];
            long sumOfLeftPriceRatings = 0;
            long sumOfRightPriceRatings = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                if (ReferToTheNeededTypeItems(typeOfItemsToBeBroken, priceRatings[i], entryPointPriceRating)
                    && ReferToTheNeededTypePriceRating(typeOfPriceRatingsSearched, priceRatings[i]))
                {
                    sumOfLeftPriceRatings += priceRatings[i];
                }
            }

            for (int i = entryPoint + 1; i < priceRatings.Length; i++)
            {
                if (ReferToTheNeededTypeItems(typeOfItemsToBeBroken, priceRatings[i], entryPointPriceRating)
                    && ReferToTheNeededTypePriceRating(typeOfPriceRatingsSearched, priceRatings[i]))
                {
                    sumOfRightPriceRatings += priceRatings[i];
                }
            }

            if (sumOfLeftPriceRatings >= sumOfRightPriceRatings)
            {
                Console.WriteLine($"Left - {sumOfLeftPriceRatings}");
            }
            else
            {
                Console.WriteLine($"Right - {sumOfRightPriceRatings}");
            }
        }

        static bool ReferToTheNeededTypeItems(string neededType, int priceRating, int entryPointPriceRating)
        {
            if (neededType == "expensive")
            {
                return priceRating >= entryPointPriceRating;
            }
            else
            {
                return priceRating < entryPointPriceRating;
            }
        }

        static bool ReferToTheNeededTypePriceRating(string neededPriceRating, int priceRating)
        {
            if (neededPriceRating == "positive")
            {
                return priceRating >= 0;
            }
            else if (neededPriceRating == "negative")
            {
                return priceRating < 0;
            }

            return true;
        }
    }
}
