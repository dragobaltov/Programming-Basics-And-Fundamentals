using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacepin
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceUS = decimal.Parse(Console.ReadLine());
            long kilogramsUS = long.Parse(Console.ReadLine());
            decimal priceUK = decimal.Parse(Console.ReadLine());
            long kilogramsUK = long.Parse(Console.ReadLine());
            decimal priceChina = decimal.Parse(Console.ReadLine());
            long kilogramsChina = long.Parse(Console.ReadLine());

            decimal priceUSInLeva = (priceUS / 0.58m) / kilogramsUS;
            decimal priceUKInLeva = (priceUK / 0.41m) / kilogramsUK;
            decimal priceChinaInLeva = (priceChina * 0.27m) / kilogramsChina;

            if (priceUSInLeva < priceUKInLeva && priceUSInLeva < priceChinaInLeva)
            {
                Console.WriteLine($"US store. {priceUSInLeva:F2} lv/kg");
                Console.WriteLine($"Difference {Math.Max(priceUKInLeva, priceChinaInLeva) - priceUSInLeva:F2} lv/kg");
            }
            else if (priceUKInLeva < priceUSInLeva && priceUKInLeva < priceChinaInLeva)
            {
                Console.WriteLine($"UK store. {priceUKInLeva:F2} lv/kg");
                Console.WriteLine($"Difference {Math.Max(priceUSInLeva, priceChinaInLeva) - priceUKInLeva:F2} lv/kg");
            }
            else if (priceChinaInLeva < priceUSInLeva && priceChinaInLeva < priceUKInLeva)
            {
                Console.WriteLine($"Chinese store. {priceChinaInLeva:F2} lv/kg");
                Console.WriteLine($"Difference {Math.Max(priceUSInLeva, priceUKInLeva) - priceChinaInLeva:F2} lv/kg");
            }
        }
    }
}
