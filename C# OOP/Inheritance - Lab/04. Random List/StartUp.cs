namespace CustomRandomList
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            var list = new RandomList();
            list.Add("dog");
            list.Add("cat");
            list.Add("cow");
            Console.WriteLine(list.RandomString());
        }
    }
}
