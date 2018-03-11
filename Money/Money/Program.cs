using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chinesseValute = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            double bitcoinsInLeva = bitcoins * 1168;
            double commissionInPro = commission / 100;
            double chinesseValuteInLeva = (chinesseValute * 0.15) * 1.76;
            //1 биткойн = 1168 лева.
            //1 китайски юан = 0.15 долара.
            //1 долар = 1.76 лева.
            //1 евро = 1.95 лева.

            Console.WriteLine($"{((bitcoinsInLeva + chinesseValuteInLeva) - commissionInPro * (bitcoinsInLeva + chinesseValuteInLeva)) / 1.95:F2}");
        }
    }
}
