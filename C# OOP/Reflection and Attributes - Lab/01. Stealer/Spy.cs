using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] fieldsToInvestigate)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(
            BindingFlags.Instance | BindingFlags.Static
            | BindingFlags.NonPublic | BindingFlags.Public);

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (var field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }
}
