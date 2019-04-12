using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        Type type = typeof(StartUp);
        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

        foreach (var method in methods
            .Where(m => m.CustomAttributes.Any(a => a.AttributeType == typeof(AuthorAttribute))))
        {
            var atributes = method.GetCustomAttributes(false);
            foreach (AuthorAttribute atribute in atributes)
            {
                Console.WriteLine($"{method.Name} is written by {atribute.Name}");
            }
        }
    }
}
