using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaVariable = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexaVariable, 16));
        }
    }
}
