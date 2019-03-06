namespace P03_JediGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(int[] coordinates)
        {
            this.CurrentRow = coordinates[0];
            this.CurrentCol = coordinates[1];
        }

        public int CurrentRow { get; set; }

        public int CurrentCol { get; set; }
    }
}
