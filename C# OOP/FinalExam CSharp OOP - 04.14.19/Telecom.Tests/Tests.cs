namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        private Phone phone;

        [SetUp]
        public void Setup()
        {
            this.phone = new Phone("Tro", "Shka");
        }

        [Test]
        public void Getters_ShouldWorkCorrecty()
        {
            Assert.AreEqual("Tro", phone.Make);
            Assert.AreEqual("Shka", phone.Model);
        }

        [Test]
        public void MakeSetter_ShouldThrowExceptionIfValueIsNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Phone(null, "Shka"));
            Assert.Throws<ArgumentException>(() => new Phone("", "Shka"));
        }

        [Test]
        public void ModelSetter_ShouldThrowExceptionIfValueIsNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Phone("Tro", null));
            Assert.Throws<ArgumentException>(() => new Phone("Tro", ""));
        }

        [Test]
        public void AddContact_ShouldWorkCorrectly()
        {
            this.phone.AddContact("Name", "08PhNumber");

            Assert.AreEqual(1, this.phone.Count);
        }

        [Test]
        public void AddContact_ShouldThrowException()
        {
            this.phone.AddContact("Name", "08PhNumber");

            Assert.Throws<InvalidOperationException>(
                () => this.phone.AddContact("Name", "08PhNumber"));
        }

        [Test]
        public void Call_ShouldReturnCorrectString()
        {
            this.phone.AddContact("Name", "08PhNumber");

            Assert.AreEqual($"Calling Name - 08PhNumber...", this.phone.Call("Name"));
        }

        [Test]
        public void Call_ShouldThrowExceptionIfNameDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.phone.Call("Name"));
        }
    }
}