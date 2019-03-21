namespace _04.Recharge.Models
{
    using Contracts;

    public class Robot : Worker, IRechargeable
    {
        private int currentPower;
        private int capacity;

        public Robot(string id, int capacity) : base(id)
        {
            this.capacity = capacity;
        }
        
        public override void Work(int hours)
        {
            if (hours > this.currentPower)
            {
                hours = currentPower;
            }

            base.Work(hours);

            this.currentPower -= hours;
        }

        public void Recharge()
        {
            this.currentPower = this.capacity;
        }
    }
}