using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins.");
            string firstAmount = Console.ReadLine();
            double total = Convert.ToDouble(firstAmount);
            Console.WriteLine($"{total} is equal to ...");
            int goldValue = 10;
            int silverValue = 5;
            double goldCoins = Math.Floor(total / goldValue);
            double leftOver = total % goldValue;

            double silverCoins = Math.Floor(leftOver / silverValue);
            double remainder = leftOver % silverValue;

            Console.WriteLine($"Gold coins:{goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins:{remainder}");
        }
    }
}
