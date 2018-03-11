using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long TreatedPatients = 0;
            long UntreatedPatients = 0;

            long doctor = 7;


            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (UntreatedPatients > TreatedPatients))
                {
                    doctor++;
                }

                long patients = long.Parse(Console.ReadLine());

                if (patients == doctor)
                {
                    TreatedPatients += doctor;
                }
                else if (patients > doctor)
                {

                    TreatedPatients += doctor;
                    patients -= doctor;
                    UntreatedPatients += patients;

                }
                else
                {
                    TreatedPatients += patients;
                }

            }
            Console.WriteLine("Treated patients: {0}.", TreatedPatients);
            Console.WriteLine("Untreated patients: {0}.", UntreatedPatients);
        }
    }
}
