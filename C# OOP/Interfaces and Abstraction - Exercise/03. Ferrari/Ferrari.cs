namespace _03._Ferrari
{
    public class Ferrari : ICar
    {
        private string model;
        private string driversName;

        public Ferrari(string driversName)
        {
            this.model = "488-Spider";
            this.driversName = driversName;
        }

        public string PushTheGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string Usebrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.model}/{this.Usebrakes()}/{this.PushTheGasPedal()}/{this.driversName}";
        }
    }
}
