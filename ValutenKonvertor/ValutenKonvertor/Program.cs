using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValutenKonvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = decimal.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();
            var result = 0.0M;

            if(firstCurrency == "BGN")
            {
                if(secondCurrency == "USD")
                {
                    result = value * 1.79549M;
                }
                else if(secondCurrency == "EUR")
                {
                    result = value * 1.95583M;
                }
                else if(secondCurrency == "GBP")
                {
                    result = value * 2.53405M;
                }
            }
            else if(firstCurrency == "USD")
            {
                if(secondCurrency == "BGN")
                {
                    result = value *;
                }
                else if(secondCurrency == )
            }
            else if(firstCurrency == "EUR")
            {

            }
            else if (firstCurrency == "GBP")
            {

            }
        }
    }
}
