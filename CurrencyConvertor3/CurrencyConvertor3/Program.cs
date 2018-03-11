using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();
            //Курс  USD     EUR     GBP
            //1 BGN 1.79549 1.95583 2.53405

            if (inputCurrency == "BGN")
            {
                if (outputCurrency == "USD")
                {
                    Console.WriteLine($"{sum / 1.79549:F2} USD");
                }
                else if (outputCurrency == "EUR")
                {
                    Console.WriteLine($"{sum / 1.95583:F2} EUR");
                }
                else if (outputCurrency == "GBP")
                {
                    Console.WriteLine($"{sum / 2.53405:F2} GBP");
                }
                else if (outputCurrency == "BGN")
                {
                    Console.WriteLine($"{sum:F2} BGN");
                }
            }
            else if (inputCurrency == "USD")
            {
                if (outputCurrency == "BGN")
                {
                    Console.WriteLine($"{sum * 1.79549:F2} BGN");
                }
                else if (outputCurrency == "EUR")
                {
                    Console.WriteLine($"{sum * 1.79549 / 1.95583:F2} EUR");
                }
                else if (outputCurrency == "GBP")
                {
                    Console.WriteLine($"{sum * 1.79549 / 2.53405:F2} GBP");
                }
                else if (outputCurrency == "USD")
                {
                    Console.WriteLine($"{sum:F2} USD");
                }
            }
            else if (inputCurrency == "EUR")
            {
                if (outputCurrency == "BGN")
                {
                    Console.WriteLine($"{sum * 1.95583:F2} BGN");
                }
                else if (outputCurrency == "GBP")
                {
                    Console.WriteLine($"{sum * 1.95583 / 2.53405:F2} GBP");
                }
                else if (outputCurrency == "USD")
                {
                    Console.WriteLine($"{sum * 1.95583 / 1.79549:F2} USD");
                }
                else if (outputCurrency == "EUR")
                {
                    Console.WriteLine($"{sum:F2} EUR");
                }
            }
            else if (inputCurrency == "GBP")
            {
                if (outputCurrency == "BGN")
                {
                    Console.WriteLine($"{sum * 2.53405:F2} BGN");
                }
                else if (outputCurrency == "EUR")
                {
                    Console.WriteLine($"{sum * 2.53405 / 1.95583:F2} EUR");
                }
                else if (outputCurrency == "USD")
                {
                    Console.WriteLine($"{sum * 2.53405 / 1.79549:F2} USD");
                }
                else if (outputCurrency == "GBP")
                {
                    Console.WriteLine($"{sum:F2} GBP");
                }
            }
        }
    }
}
