namespace CustomStack
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());

            stack.AddRange(new string[] { "Dog", "Cat", "Puppy" });

            Console.WriteLine(stack.IsEmpty());
        }
    }
}
