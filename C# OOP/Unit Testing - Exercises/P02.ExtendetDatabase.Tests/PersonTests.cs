namespace Tests
{
    using NUnit.Framework;
    using P02.ExtendedDatabase;
    using System;

    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void PersonIdSeter_ShouldThrowExceptionIfIdIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Person(-1, "Gosho"),
                "Creating persont with negative Id should throw exception!");
        }

        [Test]
        public void PersonUsenameSeter_ShouldThrowExceptionIfNameIsNullOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => new Person(123, ""),
                "Creating persont with emty Username should throw exception!");
        }
    }
}