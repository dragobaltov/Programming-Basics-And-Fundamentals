using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGalery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minutes:D2}");
            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if(photoSize < 1000000)
            {
                photoSize /= 1000;
                Console.WriteLine($"Size: {photoSize}KB");
            }
            else
            {
                photoSize /= 1000000;
                Console.WriteLine($"Size: {photoSize}MB");
            }
            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if(width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }


        }
    }
}
