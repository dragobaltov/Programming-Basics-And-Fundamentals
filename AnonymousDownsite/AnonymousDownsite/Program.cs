using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int sites = int.Parse(Console.ReadLine());
            long securityKey = long.Parse(Console.ReadLine());
            BigInteger securityToken = BigInteger.Pow(securityKey, sites);
            decimal totalLoss = 0;

            for (long i = 0; i < sites; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string siteName = tokens[0];
                long siteVisits = long.Parse(tokens[1]);
                decimal pricePerVisit = decimal.Parse(tokens[2]);
                decimal siteLoss = siteVisits * pricePerVisit;
                totalLoss += siteLoss;

                Console.WriteLine(siteName);
            }

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
