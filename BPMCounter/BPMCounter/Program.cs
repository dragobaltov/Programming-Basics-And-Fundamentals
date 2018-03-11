using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            double bars = Math.Round(beats / 4.0, 1);
            int minutes = beats / bpm;
            double seconds = Math.Floor((beats * 1.0 / bpm - minutes) * 60);
            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
