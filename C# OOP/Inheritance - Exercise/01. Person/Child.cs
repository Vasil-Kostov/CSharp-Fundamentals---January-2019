﻿namespace _01._Person
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Child : Person
    {        
        public Child(string name, int age)
            : base(name, age)
        {
        }
        
        public override int Age
        {
            get => base.Age;

            protected set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }

                base.Age = value;
            }
        }
    }
}
