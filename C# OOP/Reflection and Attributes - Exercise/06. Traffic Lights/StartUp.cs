namespace _06._Traffic_Lights
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        static void Main()
        {
            string[] lights = Console.ReadLine().Split();

            int n = int.Parse(Console.ReadLine());

            Type type = typeof(TrafficLight);

            var instance = Activator.CreateInstance(type, new object[] { lights });

            var method = type.GetMethods(
                BindingFlags.NonPublic 
                | BindingFlags.Instance)
                .Where(m => m.Name == "ChangeSignal")
                .First();

            for (int i = 0; i < n; i++)
            {
                method.Invoke(instance, null);
                Console.WriteLine(instance);
            }
        }
    }
}
