namespace _06._Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override string Gender => "Female";

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
