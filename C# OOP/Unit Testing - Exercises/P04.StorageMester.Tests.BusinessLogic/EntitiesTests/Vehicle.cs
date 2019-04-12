namespace P04.StorageMaster.Tests.BusinessLogic.EntitiesTests
{
    using NUnit.Framework;
    using Entities.Products;
    using Entities.Vehicles;
    using System;

    [TestFixture]
    public class VehicleTests
    {
        private Vehicle vehicle;
        private Product product;

        [SetUp]
        public void Setup()
        {
            this.vehicle = new Van();
            this.product = new HardDrive(1);
        }

        [Test]
        public void Van_InitialCapacity_ShouldBeTwo()
        {
            Assert.That(this.vehicle.Capacity.Equals(2));
        }

        [Test]
        public void Truck_InitialCapacity_ShouldBeFive()
        {
            this.vehicle = new Truck();

            Assert.That(this.vehicle.Capacity.Equals(5));
        }

        [Test]
        public void Semi_InitialCapacity_ShouldBeTen()
        {
            this.vehicle = new Semi();

            Assert.That(this.vehicle.Capacity.Equals(10));
        }

        [Test]
        public void IsEmpty_ShouldReturnTrue()
        {
            Assert.IsTrue(this.vehicle.IsEmpty);
        }

        [Test]
        public void IsFull_ShouldReturnFalse()
        {
            Assert.IsFalse(this.vehicle.IsFull);
        }

        [Test]
        public void LoadProduct_ShouldWorkCorrectly()
        {
            this.vehicle.LoadProduct(this.product);

            Assert.IsTrue(this.vehicle.Trunk.Count.Equals(1));
        }

        [Test]
        public void LoadProduct_ShouldThrowExceptionIfAlreadyFull()
        {
            this.vehicle.LoadProduct(this.product);
            this.vehicle.LoadProduct(this.product);

            Assert.Throws<InvalidOperationException>(
                () => this.vehicle.LoadProduct(product));
        }

        [Test]
        public void IsEmpty_ShouldReturnFalse()
        {
            this.vehicle.LoadProduct(this.product);
            Assert.IsFalse(this.vehicle.IsEmpty);
        }

        [Test]
        public void IsFull_ShouldReturnTrue()
        {
            this.vehicle.LoadProduct(this.product);
            this.vehicle.LoadProduct(this.product);

            Assert.IsTrue(this.vehicle.IsFull);
        }

        [Test]
        public void Unload_ShouldWorkCorrectly()
        {
            this.vehicle.LoadProduct(product);

            Product returnedProduct = vehicle.Unload();

            Assert.AreEqual(product, returnedProduct);
        }

        [Test]
        public void Unload_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(
                () => this.vehicle.Unload());
        }
    }
}
