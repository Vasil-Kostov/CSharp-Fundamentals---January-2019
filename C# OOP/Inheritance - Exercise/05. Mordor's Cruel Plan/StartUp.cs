namespace MordorsCruelPlan
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Gandalf gandalf = new Gandalf();

            gandalf.Eat(Console.ReadLine().Split());

            Console.WriteLine(gandalf);
        }
    }
}
