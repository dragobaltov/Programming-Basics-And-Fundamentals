using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double BGN = double.Parse(Console.ReadLine());
            double USD = 1.79549 * BGN;
            double EUR = 1.95583 * BGN;
            double GBP = 2.53405 * BGN;


