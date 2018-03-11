using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double borderOfSignificance = double.Parse(Console.ReadLine());
        double previousPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = PercentageOfDifference(previousPrice, currentPrice);
            bool isSignificantDifference = Difference(difference, borderOfSignificance);
            string message = GetMessage(currentPrice, previousPrice, difference, isSignificantDifference);

            Console.WriteLine(message);

            previousPrice = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double previousPrice, double difference, bool etherTrueOrFalse)
    {
        string message = "";

        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
        }

        return message;
    }

    private static bool Difference(double borderOfSignificance, double difference)
    {
        if (Math.Abs(borderOfSignificance) >= difference)
        {
            return true;
        }
        return false;
    }

    private static double PercentageOfDifference(double previousPrice, double currentPrice)
    {
        double result = (currentPrice - previousPrice) / previousPrice;
        return result;
    }
}

