using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int maxSnow = 0;
            int maxTime = 0;
            int maxSnowBallQuality = 0;
            BigInteger maxSnowBallValue = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > maxSnowBallValue)
                {
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxSnowBallQuality = snowballQuality;
                    maxSnowBallValue = snowballValue;
                }

            }

            
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxSnowBallValue} ({maxSnowBallQuality})");
        }
    }
}
