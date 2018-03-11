using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArriving = int.Parse(Console.ReadLine());
            int minuteArriving = int.Parse(Console.ReadLine());
            int examTimeInMin = hourExam * 60 + minuteExam;
            int arrivingTimeInMin = hourArriving * 60 + minuteArriving;
            int hours1 = (examTimeInMin - arrivingTimeInMin) / 60;
            int min1 = (examTimeInMin - arrivingTimeInMin) % 60;
            int hours2 = (arrivingTimeInMin - examTimeInMin) / 60;
            int min2 = (arrivingTimeInMin - examTimeInMin) % 60;

            if (examTimeInMin == arrivingTimeInMin)
            {
                Console.WriteLine("On time");
            }
            else if (examTimeInMin > arrivingTimeInMin)
            {
                if (examTimeInMin - arrivingTimeInMin <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{examTimeInMin - arrivingTimeInMin} minutes before the start");
                }
                else if (examTimeInMin - arrivingTimeInMin > 30 && examTimeInMin - arrivingTimeInMin < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{examTimeInMin - arrivingTimeInMin} minutes before the start");
                }
                else if (examTimeInMin - arrivingTimeInMin >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours1}:{min1:00} hours before the start");
                }
            }
            else if (examTimeInMin < arrivingTimeInMin)
            {
                if (arrivingTimeInMin - examTimeInMin < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{arrivingTimeInMin - examTimeInMin} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours2}:{min2:00} hours after the start");
                }
            }
        }
    }
}
