namespace _04.WorkForce
{
    class PartTimeEmployee : Employee
    {
        private const int WorkHoursPerWeek = 20;

        public PartTimeEmployee(string name) 
            : base(name, WorkHoursPerWeek)
        {
        }
    }
}
