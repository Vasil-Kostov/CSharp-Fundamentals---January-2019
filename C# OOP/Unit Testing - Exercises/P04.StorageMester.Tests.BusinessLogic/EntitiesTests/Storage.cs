namespace P04.StorageMaster.Tests.BusinessLogic.EntitiesTests
{
    using NUnit.Framework;
    using Entities.Products;
    using Entities.Storage;
    using System.Linq;

    [TestFixture]
    public class StorageTests
    {
        private Storage storage;
        private Product product;

        [SetUp]
        public void Setup()
        {
            this.storage = new Warehouse("Cellar");
            this.product = new HardDrive(1);
        }

        [Test]
        public void WarehouseConstructor_ShouldSetCorrectName()
        {
            Assert.That(this.storage.Name == "Cellar");
        }

        [Test]
        public void WarehouseConstructor_ShouldSetCorrectCapacity()
        {
            Assert.That(this.storage.Capacity == 10);
        }

        [Test]
        public void WarehouseConstructor_ShouldSetCorrectGarageSlots()
        {
            Assert.That(this.storage.GarageSlots == 10);
        }
        [Test]
        public void WarehouseConstructor_ShouldSetThreeDefaultVehicles()
        {
            Assert.That(this.storage
                .Garage
                .Where(v => v != null)
                .ToList()
                .Count == 3);
        }

        [Test]
        public void DistributionCenter_ShouldSetCorrectName()
        {
            this.storage = new DistributionCenter("Center");

            Assert.That(this.storage.Name == "Center");
        }

        [Test]
        public void DistributionCenter_ShouldSetCorrectCapacity()
        {
            this.storage = new DistributionCenter("Center");

            Assert.That(this.storage.Capacity == 2);
        }

        [Test]
        public void DistributionCenter_ShouldSetCorrectGarageSlots()
        {
            this.storage = new DistributionCenter("Center");

            Assert.That(this.storage.GarageSlots == 5);
        }
        [Test]
        public void DistributionCenter_ShouldSetThreeDefaultVehicles()
        {
            this.storage = new DistributionCenter("Center");

            Assert.That(this.storage
                .Garage
                .Where(v => v != null)
                .ToList()
                .Count == 3);
        }

        [Test]
        public void AutumatedWarehouse_ShouldSetCorrectName()
        {
            this.storage = new AutomatedWarehouse("IWHouse");

            Assert.That(this.storage.Name == "IWHouse");
        }

        [Test]
        public void AutumatedWarehouse_ShouldSetCorrectCapacity()
        {
            this.storage = new AutomatedWarehouse("IWHouse");

            Assert.That(this.storage.Capacity == 1);
        }

        [Test]
        public void AutumatedWarehouse_ShouldSetCorrectGarageSlots()
        {
            this.storage = new AutomatedWarehouse("IWHouse");

            Assert.That(this.storage.GarageSlots == 2);
        }
        [Test]
        public void AutumatedWarehouse_ShouldSetOneDefaultVehicle()
        {
            this.storage = new AutomatedWarehouse("IWHouse");

            Assert.That(this.storage
                .Garage
                .Where(v => v != null)
                .ToList()
                .Count == 1);
        }
    }
}
