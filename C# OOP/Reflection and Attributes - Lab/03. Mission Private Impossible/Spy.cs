using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);
        MethodInfo[] classPrivateMethods = classType.GetMethods(
            BindingFlags.NonPublic | BindingFlags.Instance);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classPrivateMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().TrimEnd();
    }
}
