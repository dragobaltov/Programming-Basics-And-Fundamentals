using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            var result = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var resultAfter1000Days = result.AddDays(999);
            Console.WriteLine(resultAfter1000Days.ToString("dd-MM-yyyy"));
        }
    }
}
