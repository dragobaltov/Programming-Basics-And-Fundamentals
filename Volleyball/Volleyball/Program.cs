using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekednsHome = int.Parse(Console.ReadLine());
            int weekednsSofia = 48 - weekednsHome;

            if (typeYear == "normal")
            {
                Console.WriteLine(Math.Truncate(weekednsSofia * 3.0 / 4 + weekednsHome + holidays * 2.0 / 3));
            }
            else if(typeYear == "leap")
            {
                Console.WriteLine(Math.Truncate((weekednsSofia * 3.0 / 4 + weekednsHome + holidays * 2.0 / 3) +
                                  (weekednsSofia * 3.0 / 4 + weekednsHome + holidays * 2.0 / 3) * 0.15));
            }
        }
    }
}
