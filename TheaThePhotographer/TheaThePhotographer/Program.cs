using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long takenPictures = long.Parse(Console.ReadLine());
            long filterTimeForOnePictureInSec = long.Parse(Console.ReadLine());
            long percentageOfGoodPictures = long.Parse(Console.ReadLine());
            long uploadingTimeForOnePicture = long.Parse(Console.ReadLine());
            
            long goodEnoughPictures = (long)Math.Ceiling(takenPictures * percentageOfGoodPictures * 0.01);
            
            long filterTimeInSec = takenPictures * filterTimeForOnePictureInSec;
            long uploadingTimeInSec = goodEnoughPictures * uploadingTimeForOnePicture;
            long wholeTimeInSec = filterTimeInSec + uploadingTimeInSec;
            long seconds = wholeTimeInSec % 60;
            long wholeTimeInMin = wholeTimeInSec / 60;
            long minutes = wholeTimeInMin % 60;
            long wholeTimeInHours = wholeTimeInMin / 60;
            long hours = wholeTimeInHours % 24;
            long wholeTimeInDays = wholeTimeInHours / 24;

            Console.WriteLine($"{wholeTimeInDays}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
