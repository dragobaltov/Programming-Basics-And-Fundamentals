using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            
            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        if (specialNumber >= controlNumber)
                            break;
                        string ijk = Convert.ToString(i) + Convert.ToString(j) + Convert.ToString(k);
                        int ijk2 = Convert.ToInt16(ijk);
                        if (ijk2 % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (ijk2 % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (ijk2 % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                    }
                    if (specialNumber >= controlNumber)
                        break;
                }
                if (specialNumber >= controlNumber)
                    break;
            }

            if (specialNumber >= controlNumber)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
            }
            else
            {
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            }
        }
    }
}
