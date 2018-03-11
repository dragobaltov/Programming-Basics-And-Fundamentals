using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());
            string typeSmallerNum = null;
            string typeBiggerNum = null;
            double overflow = 0;
            ulong smallerNum = 0;
            ulong biggerNum = 0;

            if (num1 >= num2)
            {
                smallerNum = num2;
                biggerNum = num1;
            }
            else
            {
                smallerNum = num1;
                biggerNum = num2;
            }

            if (biggerNum <= byte.MaxValue)
            {
                typeBiggerNum = "byte";
            }
            else if (biggerNum <= ushort.MaxValue)
            {
                typeBiggerNum = "ushort";
            }
            else if (biggerNum <= uint.MaxValue)
            {
                typeBiggerNum = "uint";
            }
            else
            {
                typeBiggerNum = "ulong";
            }

            if (smallerNum <= byte.MaxValue)
            {
                typeSmallerNum = "byte";
                overflow = Math.Round(biggerNum * 1.0 / byte.MaxValue);
            }
            else if (smallerNum <= ushort.MaxValue)
            {
                typeSmallerNum = "ushort";
                overflow = Math.Round(biggerNum * 1.0 / ushort.MaxValue);
            }
            else if (smallerNum <= uint.MaxValue)
            {
                typeSmallerNum = "uint";
                overflow = Math.Round(biggerNum * 1.0 / uint.MaxValue);
            }
            else
            {
                typeSmallerNum = "ulong";
                overflow = Math.Round(biggerNum * 1.0 / ulong.MaxValue);
            }

            Console.WriteLine($"bigger type: {typeBiggerNum}");
            Console.WriteLine($"smaller type: {typeSmallerNum}");
            Console.WriteLine($"{biggerNum} can overflow {typeSmallerNum} {overflow} times");
        }
    }
}
