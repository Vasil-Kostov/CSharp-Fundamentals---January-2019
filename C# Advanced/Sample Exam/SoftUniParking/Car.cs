namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();

            printFormat.AppendLine($"Make: {this.Make}");
            printFormat.AppendLine($"Model: {this.Model}");
            printFormat.AppendLine($"HorsePower: {this.HorsePower}");
            printFormat.Append($"RegistrationNumber: {this.RegistrationNumber}");

            return printFormat.ToString();
        }
    }
}
