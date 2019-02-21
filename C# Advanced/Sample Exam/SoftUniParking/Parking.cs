namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count => this.cars.Count();

        public string AddCar(Car car)
        {
            if (!this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                if (this.cars.Count < this.capacity)
                {
                    this.cars.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
                else
                {
                    return "Parking is full!";
                }
            }
            else
            {
                return "Car with that registration number, already exists!";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                this.cars.Remove(this.cars.Find(c => c.RegistrationNumber == registrationNumber));

                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return this.cars.Find(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            registrationNumbers.ForEach(rn => this.RemoveCar(rn));
        }
    }
}
