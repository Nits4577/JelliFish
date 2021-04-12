using System;

namespace JeliFish
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:
            Console.Write("Enter String: ");
            var val = Console.ReadLine();
            var str = JellyFishManager.GetDirectionFromString(val);
            var outPut = JellyFishManager.GetValidString(val) + str;
            Console.WriteLine(outPut);
            var getKey = Console.ReadKey();
            if (getKey.Key == ConsoleKey.Enter)
            {
                goto Start;
            }
        }

    }
}
