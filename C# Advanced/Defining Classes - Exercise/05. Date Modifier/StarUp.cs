namespace DefiningClasses
{
    using System;

    public class StarUp
    {
        public static void Main()
        {
            string firstDateAsStr = Console.ReadLine();
            string secondDateAsStr = Console.ReadLine();

            DateModifier currentModif =  new DateModifier();

            currentModif.Difference = DateModifier.GetDifferenceBetweenDates(firstDateAsStr, secondDateAsStr);

            Console.WriteLine(currentModif.Difference);
        }
    }
}
