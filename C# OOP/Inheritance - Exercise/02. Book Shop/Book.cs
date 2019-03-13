namespace _02._Book_Shop
{
    using System;
    using System.Linq;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get => this.title;

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get => this.author;

            private set
            {
                if (!string.IsNullOrEmpty(value) &&  char.IsDigit(value.Split().Last()[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }

                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get => this.price;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();
            printFormat.AppendLine($"Type: {this.GetType().Name}");
            printFormat.AppendLine($"Title: {this.Title}");
            printFormat.AppendLine($"Author: {this.Author}");
            printFormat.AppendLine($"Price: {this.Price:F2}");

            return printFormat.ToString().TrimEnd();
        }
    }
}
