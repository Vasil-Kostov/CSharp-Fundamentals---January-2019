namespace _02.KingsGambit.Models
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
