using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int untreatedPatients = 0;
            int treatedPatients = 0;
            for (int i = 1; i <= period; i++)
            {
                int patientsForDay = int.Parse(Console.ReadLine());
                if (patientsForDay >= doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += (patientsForDay - treatedPatients);
                }
                else
                {
                    treatedPatients += patientsForDay;
                }
                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors += 1;
                    }
                }
            }
            
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
