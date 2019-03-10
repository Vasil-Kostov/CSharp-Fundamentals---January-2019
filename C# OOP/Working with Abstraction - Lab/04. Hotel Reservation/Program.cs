namespace _04._Hotel_Reservation
{
    using System;

    public class PriceCalculator
    {
        static void Main()
        {
            string[] inputArr = Console.ReadLine().Split();

            decimal pricePerDay = decimal.Parse(inputArr[0]);
            int numberOfDayes = int.Parse(inputArr[1]);
            string season = inputArr[2];
            string discountType = inputArr.Length == 4 ? inputArr[3] : "None";

            decimal totalPrice = pricePerDay * numberOfDayes;

            switch (season)
            {
                case "Autumn": totalPrice *= (int)Season.Autumn; break;
                case "Spring": totalPrice *= (int)Season.Spring; break;
                case "Winter": totalPrice *= (int)Season.Winter; break;
                case "Summer": totalPrice *= (int)Season.Summer; break;
            }

            switch (discountType)
            {
                case "None": totalPrice *= (10 - (int)DiscountType.None) / 10.0m; break;
                case "SecondVisit": totalPrice *= (10 - (int)DiscountType.SecondVisit) / 10.0m; break;
                case "VIP": totalPrice *= (10 - (int)DiscountType.VIP) / 10.0m; break;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
