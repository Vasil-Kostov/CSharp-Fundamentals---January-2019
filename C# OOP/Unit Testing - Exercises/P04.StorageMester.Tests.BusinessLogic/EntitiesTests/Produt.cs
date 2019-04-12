namespace P04.StorageMaster.Tests.BusinessLogic.EntitiesTests
{
    using NUnit.Framework;
    using Entities.Products;
    using System;

    [TestFixture]
    public class ProductTests
    {
        private Product product;

        [SetUp]
        public void Setup()
        {
            this.product = new HardDrive(1);
        }

        [Test]
        public void HardDrive_InitialWeight_ShouldBeOne()
        {
            Assert.That(this.product.Weight.Equals(1));
        }

        [Test]
        public void Ram_InitialWeight_ShouldBeZeroPointOne()
        {
            this.product = new Ram(1);

            Assert.That(this.product.Weight.Equals(0.1));
        }

        [Test]
        public void SolidStateDrive_InitialWeight_ShouldBeZeroPointTwo()
        {
            this.product = new SolidStateDrive(1);

            Assert.That(this.product.Weight.Equals(0.2));
        }

        [Test]
        public void Gpu_InitialWeight_ShouldBeZeroPointSeven()
        {
            this.product = new Gpu(1);

            Assert.That(this.product.Weight.Equals(0.7));
        }

        [Test]
        public void Product_PriceSetter_ShouldWorkCorrectlu()
        {
            Assert.That(this.product.Price.Equals(1));
        }

        [Test]
        public void Product_PriceSetter_ShouldThrowExceptionIfPriceIsLessThanZero()
        {
            Assert.Throws<InvalidOperationException>(
                () => this.product = new HardDrive(-1));
        }
    }
}
