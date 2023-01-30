using System;
using Bu_projectle_elaqelendirecem;

namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink1 = new Drink
            {
                Name = "Tekila",
                Price = 80,
                AlcoholPercent = 35,
            };

            Console.WriteLine($"Name : {drink1.Name}  Price : {drink1.Price}  AlcoholPercent : {drink1.AlcoholPercent}");

           
        }
    }
}
