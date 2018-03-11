using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double sumOfNaturals = 0;
            double sumOfSharp = 0;
            List<string> naturals = new List<string>();
            List<string> sharp = new List<string>();
            List<string> notes = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (numbers[i])
                {
                    case 261.63:
                        sumOfNaturals += numbers[i];
                        naturals.Add("C");
                        notes.Add("C");
                        break;
                    case 293.66:
                        sumOfNaturals += numbers[i];
                        naturals.Add("D");
                        notes.Add("D");
                        break;
                    case 329.63:
                        sumOfNaturals += numbers[i];
                        naturals.Add("E");
                        notes.Add("E");
                        break;
                    case 349.23:
                        sumOfNaturals += numbers[i];
                        naturals.Add("F");
                        notes.Add("F");
                        break;
                    case 392.00:
                        sumOfNaturals += numbers[i];
                        naturals.Add("G");
                        notes.Add("G");
                        break;
                    case 440.00:
                        sumOfNaturals += numbers[i];
                        naturals.Add("A");
                        notes.Add("A");
                        break;
                    case 493.88:
                        sumOfNaturals += numbers[i];
                        naturals.Add("B");
                        notes.Add("B");
                        break;
                    case 277.18:
                        sumOfSharp += numbers[i];
                        sharp.Add("C#");
                        notes.Add("C#");
                        break;
                    case 311.13:
                        sumOfSharp += numbers[i];
                        sharp.Add("D#");
                        notes.Add("D#");
                        break;
                    case 369.99:
                        sumOfSharp += numbers[i];
                        sharp.Add("F#");
                        notes.Add("F#");
                        break;
                    case 415.30:
                        sumOfSharp += numbers[i];
                        sharp.Add("G#");
                        notes.Add("G#");
                        break;
                    case 466.16:
                        sumOfSharp += numbers[i];
                        sharp.Add("A#");
                        notes.Add("A#");
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharp)}");
            switch (sumOfNaturals)
            {
                case 0:
                    Console.WriteLine($"Naturals sum: {sumOfNaturals}");
                    break;
                default:
                    Console.WriteLine($"Naturals sum: {sumOfNaturals:F2}");
                    break;
            }
            switch (sumOfSharp)
            {
                case 0:
                    Console.WriteLine($"Sharps sum: {sumOfSharp}");
                    break;
                default:
                    Console.WriteLine($"Sharps sum: {sumOfSharp:F2}");
                    break;
            }
        }
    }
}
