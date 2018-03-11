using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHomeTown = int.Parse(Console.ReadLine());
            int weekednsSofia = 48 - weekendsHomeTown;
            double weekednsVolleyballSofia = weekednsSofia * 0.75;
            double holidaysVolleyball = holidays * 2.0 / 3;

            if (typeYear == "normal")
            {
                Console.WriteLine($"{Math.Floor(weekednsVolleyballSofia + holidaysVolleyball + weekendsHomeTown)}");
            }
            else if (typeYear == "leap")
            {
                Console.WriteLine($"{Math.Floor((weekednsVolleyballSofia + holidaysVolleyball + weekendsHomeTown) * 1.15)}");
            }
        }
    }
}
