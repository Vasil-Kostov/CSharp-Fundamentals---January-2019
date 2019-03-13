namespace _06._Animals
{
    using System;
    using System.Text;

    public abstract class Animal
    {
        private string name;

        private int age;

        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public virtual string Gender
        {
            get => this.gender;

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();
            printFormat.AppendLine(this.GetType().Name);
            printFormat.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            printFormat.Append($"{this.ProduceSound()}");

            return printFormat.ToString();
        }
    }
}
