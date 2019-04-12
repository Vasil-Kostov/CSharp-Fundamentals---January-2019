namespace P02.ExtendedDatabase
{
    using System;

    public class Person
    {
        private long id;
        private string username;

        public Person(long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public long Id
        {
            get => this.id;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be negative!");
                }

                this.id = value;
            }
        }

        public string Username
        {
            get => this.username;

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                this.username = value;
            }
        }
    }
}
