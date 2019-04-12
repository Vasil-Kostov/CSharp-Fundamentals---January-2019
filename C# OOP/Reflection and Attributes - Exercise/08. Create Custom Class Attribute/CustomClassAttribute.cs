namespace _07._Inferno_Infinity
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class CustomClassAttribute : Attribute
    {
        public CustomClassAttribute(string author, int revision, string description
            , params string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = reviewers;
        }

        public string Author { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public string[] Reviewers { get; set; }
    }
}
