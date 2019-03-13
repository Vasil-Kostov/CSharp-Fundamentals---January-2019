namespace _03._Mankind
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            try
            {
                string[] studentInfo = Console.ReadLine().Split();

                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);

                string[] workerInfo = Console.ReadLine().Split();

                Worker worker = new Worker(workerInfo[0], workerInfo[1]
                    , decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }            
        }
    }
}
