namespace _01.EventImplementation
{
    using System;

    public delegate void NameChangeEventHandler(Object sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        private string name;

        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get => this.name;

            set
            {
                this.name = value;

                this.OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            if(this.NameChange != null)
            {
                this.NameChange(this, args);
            }
        }
    }
}
