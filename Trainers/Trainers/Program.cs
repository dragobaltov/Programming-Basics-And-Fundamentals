using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());
            decimal technicalTeamMoney = 0;
            decimal teorethicalTeamMoney = 0;
            decimal practicalTeamMoney = 0;

            for (int i = 0; i < participants; i++)
            {
                int distanceInMiles = int.Parse(Console.ReadLine());
                decimal cargoInTons = decimal.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                long distanceInMeters = distanceInMiles * 1600;
                decimal cargoInKg = cargoInTons * 1000;
                decimal participantMoney = (cargoInKg * 1.5m) - (0.7m * distanceInMeters * 2.5m);

                if (team == "Technical")
                {
                    technicalTeamMoney += participantMoney;
                }
                else if(team == "Theoretical")
                {
                    teorethicalTeamMoney += participantMoney;
                }
                else
                {
                    practicalTeamMoney += participantMoney;
                }
            }

            if (technicalTeamMoney > teorethicalTeamMoney && technicalTeamMoney > practicalTeamMoney)
            {
                Console.WriteLine($"The Technical Trainers win with ${technicalTeamMoney:F3}.");
            }
            else if(teorethicalTeamMoney > technicalTeamMoney && teorethicalTeamMoney > practicalTeamMoney)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${teorethicalTeamMoney:F3}.");
            }
            else if(practicalTeamMoney > technicalTeamMoney && practicalTeamMoney > teorethicalTeamMoney)
            {
                Console.WriteLine($"The Practical Trainers win with ${practicalTeamMoney:F3}.");
            }
        }
    }
}
