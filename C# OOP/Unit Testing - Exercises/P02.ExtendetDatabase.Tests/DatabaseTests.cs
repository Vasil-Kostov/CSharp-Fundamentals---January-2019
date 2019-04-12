namespace Tests
{
    using NUnit.Framework;
    using P02.ExtendedDatabase;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            Person firstPerson = new Person(123, "Pesho");
            Person secondPerson = new Person(123459678, "Gosho");
            this.database = new Database(firstPerson, secondPerson);
        }

        [Test]
        public void AddMethod_ShouldWorkCorectly()
        {
            Person person = new Person(159753, "Ivan");

            this.database.Add(person);

            Assert.That(this.database.Fetch().Length == 3,
                "Add method doesn't work correctly!");
        }

        [Test]
        public void AddMethod_ShouldThrowExceptionIfCollctionIsFullAlready()
        {
            for (int i = 0; i < 14; i++)
            {
                Person person = new Person(i, $"Pesho{i}");

                this.database.Add(person);
            }

            Person personSeventeen = new Person(17, $"Pesho17");

            Assert.Throws<InvalidOperationException>(() => this.database.Add(personSeventeen),
                "Add method doesn't threw expected exeption when collection is full!");
        }

        [Test]
        public void AddMethod_ShouldThrowExceptionIfUsernameIsTaken()
        {
            Person person = new Person(159753, "Pesho");

            Assert.Throws<InvalidOperationException>(() => this.database.Add(person),
                "Add method doesn't threw expected exeption when username is taken!");
        }

        [Test]
        public void AddMethod_ShouldThrowExceptionIfIdIsTaken()
        {
            Person person = new Person(123, "Ivan");

            Assert.Throws<InvalidOperationException>(() => this.database.Add(person),
                "Add method doesn't threw expected exeption when ID is taken!");
        }

        [Test]
        public void RemoveMethod_ShouldWorkCorectly()
        {
            this.database.Remove();

            Assert.That(this.database.Fetch().Length == 1,
                "Remove method doesn't work correctly!");
        }

        [Test]
        public void RemoveMethod_ShouldThrowExceptionIfCollectionIsEmpty()
        {
            this.database.Remove();
            this.database.Remove();

            Assert.Throws<InvalidOperationException>(() => this.database.Remove(),
                "Remove method doesn't threw expected exeption when collection is empty!");
        }

        [Test]
        public void FindByUsername_ShouldWorkCorectly()
        {
            Person person = new Person(159753, "Ivan");
            this.database.Add(person);

            Assert.That(this.database.FindByUsername("Ivan").Equals(person),
                "FindByUsername doesn't work correctly!");
        }

        [Test]
        public void FindByUsername_ShouldThrowExceptionIfNameIsInvalid()
        {
            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(""),
                "FindByUsername doesn't throw expected exception!");
        }

        [Test]
        public void FindByUsername_ShouldThrowExceptionIfUserNameDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername("Stamat"),
                "FindByUsername doesn't throw expected exception!");
        }

        [Test]
        public void FindById_ShouldWorkCorrectly()
        {
            Person person = new Person(159753, "Ivan");
            this.database.Add(person);

            Assert.That(this.database.FindById(159753).Equals(person),
                "FindById doesn't work correctly!");
        }

        [Test]
        public void FindById_ShouldThrowExceptionIfIdIsLessThanZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-4),
                "FindById doesn't throw expexted exception when Id is invalid!");
        }

        [Test]
        public void FindById_ShouldThrowExceptionIfIdIsDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.database.FindById(22),
                "FindById doesn't throw expexted exception when Id doesn't exist!");
        }

        [Test]
        public void InputValidation_ShouldNotPass()
        {
            Assert.Throws<InvalidOperationException>(() => this.database = new Database(),
                "Validation doesn't throw expected exception!");
        }
    }
}