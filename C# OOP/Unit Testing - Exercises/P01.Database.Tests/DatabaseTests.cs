namespace Tests
{
    using NUnit.Framework;
    using P01.Database;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            this.database = new Database(1, 2, 3, 4, 5, 6, 7, 8);
        }

        [Test]
        public void FetchMethod_ShouldWorkCorrectly()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Assert.AreEqual(this.database.Fetch(), numbers,
                "Method Remove doesn't throw expected exception!");
        }

        [Test]
        public void AddMethod_ShouldWorkCorrectly()
        {
            this.database.Add(9);

            Assert.That(this.database.Fetch().Length.Equals(9), 
                "Method Add doesnt't work correcttly");
        }

        [Test]
        public void AddMethod_ShouldThrowExceptionIfCollectinIsFull()
        {
            for (int i = 0; i < 8; i++)
            {
                this.database.Add(10);
            }

            Assert.Throws<InvalidOperationException>(() => this.database.Add(1), 
                "Method Add doesn't throw expected exception!");
        }

        [Test]
        public void RemoveMethod_ShouldWorkCorrectly()
        {
            this.database.Remove();

            Assert.That(this.database.Fetch().Length.Equals(7),
                "Method Remove doesnt't work correcttly");
        }

        [Test]
        public void RemoveMethod_ShouldThrowExceptionIfCollectinIsFull()
        {
            for (int i = 0; i < 8; i++)
            {
                this.database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => this.database.Remove(),
                "Method Remove doesn't throw expected exception!");
        }

        [Test]
        public void InputValidation_ShouldNotPass()
        {
            Assert.Throws<InvalidOperationException>(() => this.database = new Database(),
                "Validation doesn't throw expected exception!");
        }
    }
}