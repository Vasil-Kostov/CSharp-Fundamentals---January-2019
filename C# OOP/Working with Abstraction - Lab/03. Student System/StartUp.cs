namespace P03_StudentSystem
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();

            Command command = new Command();
            command.Parse(Console.ReadLine().Split());

            while (command.Name != "Exit")
            {
                try
                {
                    if (command.Name == "Create")
                    {
                        string name = command.Arguments[0];
                        int age = int.Parse(command.Arguments[1]);
                        double grade = double.Parse(command.Arguments[2]);

                        studentSystem.Add(new Student(name, age, grade));
                    }
                    else if (command.Name == "Show")
                    {
                        Console.WriteLine(studentSystem.GetStudent(command.Arguments[0]));
                    }
                }
                catch (Exception)
                {
                }                

                command.Parse(Console.ReadLine().Split());
            }
        }
    }
}
