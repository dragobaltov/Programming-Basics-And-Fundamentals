using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinute = int.Parse(Console.ReadLine());
            int examTime = examHour * 60 + examMinute;
            int arrivingTime = arrivingHour * 60 + arrivingMinute;

            if (arrivingTime == examTime || (examTime - arrivingTime <= 30 && examTime - arrivingTime > 0))
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{examTime - arrivingTime} minutes before the start");
            }
            else if (examTime - arrivingTime > 30)
            {
                Console.WriteLine("Early");
                if (examTime - arrivingTime < 60)
                {
                    Console.WriteLine($"{examTime - arrivingTime} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Floor((examTime - arrivingTime) * 1.0 / 60)}:{(examTime - arrivingTime) * 1.0 % 60:00} hours before the start");
                }
            }
            else if (arrivingTime > examTime)
            {
                Console.WriteLine("Late");
                if (arrivingTime - examTime < 60)
                {
                    Console.WriteLine($"{arrivingTime - examTime} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Floor((arrivingTime - examTime) * 1.0 / 60)}:{(arrivingTime - examTime) * 1.0 % 60:00} hours after the start");
                }
            }

        }
    }
}
