using System;

namespace P02.ExtendedDatabase
{
    public class Startup
    {
        public static void Main()
        {
            Person firstPerson = new Person(1234596, "Pesho");
            Person secondPerson = new Person(123459678, "Gosho");
            Database database = new Database(firstPerson, secondPerson);
        }
    }
}
