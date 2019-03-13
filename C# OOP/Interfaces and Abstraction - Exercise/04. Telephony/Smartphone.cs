namespace _04._Telephony
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Smartphone : ICall, IBrowse
    {
        public Smartphone()
        {
            this.PhoneNumbers = new List<string>();
            this.WebSites = new List<string>();
        }

        public List<string> PhoneNumbers { get; set; }

        public List<string> WebSites { get; set; }

        public string BrowseInTheWordWideWeb()
        {
            StringBuilder browses = new StringBuilder();

            foreach (var site in WebSites)
            {
                try
                {
                    if (site.Any(c => char.IsDigit(c)))
                    {
                        throw new ArgumentException("Invalid URL!");
                    }

                    browses.AppendLine($"Browsing: {site}!");
                }
                catch (ArgumentException argEx)
                {
                    browses.AppendLine(argEx.Message);
                }
            }

            return browses.ToString().TrimEnd();
        }

        public string CallOtherPhones()
        {
            StringBuilder calls = new StringBuilder();

            foreach (var number in this.PhoneNumbers)
            {
                try
                {
                    if (!number.All(d => char.IsDigit(d)))
                    {
                        throw new ArgumentException("Invalid number!");
                    }

                    calls.AppendLine($"Calling... {number}");
                }
                catch (ArgumentException argEx)
                {
                    calls.Append(argEx.Message);
                }
            }

            return calls.ToString().TrimEnd();
        }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();

            if (PhoneNumbers.Any())
            {
                printFormat.AppendLine(this.CallOtherPhones());
            }

            if (WebSites.Any())
            {
                printFormat.AppendLine(this.BrowseInTheWordWideWeb());
            }

            return printFormat.ToString().TrimEnd();
        }
    }
}
