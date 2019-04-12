namespace P04.StorageMaster.Tests.BusinessLogic.EntitiesTests
{
    using NUnit.Framework;
    using Entities.Factories;
    using Entities.Products;
    using Entities.Storage;
    using Entities.Vehicles;
    using System;

    [TestFixture]
    public class FactoriesTests
    {
        [Test]
        public void ProductFactory_ShouldWorkCorrectly()
        {
            ProductFactory productFactory = new ProductFactory();

            Product product = productFactory.CreateProduct("Gpu", 1.2);

            Assert.That(typeof(Product).IsAssignableFrom(product.GetType()));
        }

        [Test]
        public void ProductFactory_ShouldThrowException()
        {
            ProductFactory productFactory = new ProductFactory();

            Assert.Throws<InvalidOperationException>(
                () => productFactory.CreateProduct("NotExisting", 1.2));
        }

        [Test]
        public void StorageFactory_ShouldWorkCorrectly()
        {
            StorageFactory storageFactory = new StorageFactory();

            Storage storage = storageFactory.CreateStorage("Warehouse", "WHouse");

            Assert.That(typeof(Storage).IsAssignableFrom(storage.GetType()));
        }

        [Test]
        public void StorageFactory_ShouldThrowException()
        {
            StorageFactory storageFactory = new StorageFactory();

            Assert.Throws<InvalidOperationException>(
                () => storageFactory.CreateStorage("NotExisting", "Name"));
        }

        [Test]
        public void VehicleFactory_ShouldWorkCorrectly()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();

            Vehicle vehicle = vehicleFactory.CreateVehicle("Truck");

            Assert.That(typeof(Vehicle).IsAssignableFrom(vehicle.GetType()));
        }

        [Test]
        public void VehicleFactory_ShouldThrowException()
        {
            VehicleFactory vehicleFactory = new VehicleFactory();

            Assert.Throws<InvalidOperationException>(
                () => vehicleFactory.CreateVehicle("NotExisting"));
        }
    }
}
