using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

class HarvestingFieldsTest
{
    static void Main()
    {
        Type type = typeof(HarvestingFields);
        
        List<FieldInfo> harvestedFields = new List<FieldInfo>();

        string fieldsToHarvest = Console.ReadLine();

        while (fieldsToHarvest != "HARVEST")
        {
            switch (fieldsToHarvest)
            {
                case "private":
                    harvestedFields.AddRange(type.GetFields(
                                                 BindingFlags.NonPublic 
                                                 | BindingFlags.Instance)
                                                 .Where(f => f.IsPrivate)
                                                 .ToList());
                    break;
                case "protected":
                    harvestedFields.AddRange(type.GetFields(
                                                 BindingFlags.NonPublic 
                                                 | BindingFlags.Instance)
                                                 .Where(f => f.IsFamily)
                                                 .ToList());
                    break;
                case "public":
                    harvestedFields.AddRange(type.GetFields(
                                                 BindingFlags.Instance 
                                                 | BindingFlags.Public)
                                                 .Where(f => f.IsPublic)
                                                 .ToList());
                    break;
                case "all":
                    harvestedFields.AddRange(type.GetFields(
                                                 BindingFlags.Instance 
                                                 | BindingFlags.NonPublic
                                                 | BindingFlags.Public)
                                                 .ToList());
                    break;
            }

            fieldsToHarvest = Console.ReadLine();
        }

        StringBuilder sb = new StringBuilder();

        foreach (var field in harvestedFields)
        {
            string accessModifier = field.IsPrivate ? "private"
                                   : field.IsFamily ? "protected"
                                   : "public" ;

            sb.AppendLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
        }

        Console.WriteLine(sb.ToString().TrimEnd());
    }
}
