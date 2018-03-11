using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Time_15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            DateTime time = DateTime.Parse(hours + ":" + minutes);
            DateTime addition = DateTime.Parse("0:15");
            DateTime result = time.Add(addition.TimeOfDay);

            if (result.Minute <= 9)
            {
                Console.WriteLine(result.Hour + ":" + "0" + result.Minute);
            }
            else
            {
                Console.WriteLine(result.Hour + ":" + result.Minute);
            }
        }
    }
}
