namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StudentSystem
    {
        public StudentSystem()
        {
            this.Students = new List<Student>();
        }

        public List<Student> Students { get; private set; }

        public void Add(Student student)
        {
            if (!Students.Any(s => s.Name == student.Name))
            {
                Students.Add(student);
            }
        }

        public Student GetStudent(string name)
        {
            if (!this.Students.Any(s => s.Name == name))
            {
                throw new NullReferenceException($"Student {name} doesn't exist");
            }

            return this.Students.First(s => s.Name == name);
        }
    }
}


