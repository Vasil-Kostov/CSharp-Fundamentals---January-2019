namespace _02._Black_Box_Integer
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxInteferTests
    {
        public static void Main()
        {
            Type type =typeof(BlackBoxInteger);

            var instance = Activator.CreateInstance(type, true);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string methodName = command.Split('_').First();
                int value = int.Parse(command.Split('_').Last());

                type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(instance, new object[] { value });

                var currentValue = type.GetField("innerValue",
                    BindingFlags.Instance | BindingFlags.NonPublic)
                    .GetValue(instance);

                Console.WriteLine(currentValue);

                command = Console.ReadLine();
            }
        }
    }
}
