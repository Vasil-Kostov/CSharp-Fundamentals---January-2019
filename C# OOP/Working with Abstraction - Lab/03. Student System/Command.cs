namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Command
    {        
        public Command()
        {
        }

        public string Name { get; private set; }

        public string[] Arguments { get; private set; }

        public void Parse(string[] commandParts)
        {
            this.Name = commandParts[0];

            this.Arguments = commandParts.Skip(1).ToArray();
        }
    }
}
