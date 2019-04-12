namespace P04.StorageMaster.Tests.BusinessLogic
{
    using NUnit.Framework;
    using P04.StorageMaster.Core;
    using Entities.Products;
    using Entities.Storage;
    using System.Collections.Generic;
    using System.Reflection;

    public class StorageMasterTests
    {
        private StorageMaster storageMaster;

        [SetUp]
        public void Setup()
        {
            this.storageMaster = new StorageMaster();
        }

        [Test]
        public void Constructor_ShouldCreateInstances()
        {
            Assert.IsTrue(storageMaster.GetType() == typeof(StorageMaster));
        }

        [Test]
        public void AddProduct_ShouldWorkCorrectly()
        {
            this.storageMaster.AddProduct("Gpu", 2);

            FieldInfo productsPool = typeof(StorageMaster)
                .GetField("productsPool"
                , BindingFlags.NonPublic | BindingFlags.Instance);

            var productsPoolValue = productsPool
                .GetValue(storageMaster)
                as Dictionary<string, Stack<Product>>;

            Assert.IsTrue(productsPoolValue.ContainsKey("Gpu"));
        }

        [Test]
        public void AddProduct_ShouldReturnCorrectString()
        {
            MethodInfo method = typeof(StorageMaster)
                .GetMethod("AddProduct");

            string productType = "Gpu";

            Assert.That(method.Invoke(storageMaster, new object[] { productType, 2 })
                , Is.EqualTo($"Added {productType} to pool"));
        }

        [Test]
        public void RegisterStorage_ShouldWorkCorrectly()
        {
            this.storageMaster.RegisterStorage("Warehouse", "NewWHouse");

            FieldInfo storageRegistry = typeof(StorageMaster)
                .GetField("storageRegistry"
                , BindingFlags.NonPublic | BindingFlags.Instance);

            var storageRegistryValue = storageRegistry
                .GetValue(this.storageMaster)
                as Dictionary<string, Storage>;

            Assert.IsTrue(storageRegistryValue.ContainsKey("NewWHouse"));
        }

        [Test]
        public void RegisterStorage_ShouldReturnTheCorrectString()
        {
            MethodInfo method = typeof(StorageMaster)
                .GetMethod("RegisterStorage");

            string storageName = "NewStorage";

            Assert.That(method.Invoke(storageMaster, new object[] { "Warehouse", storageName })
                , Is.EqualTo($"Registered {storageName}"));
        }

        [Test]
        public void SelectVehicle_ShouldWorkCorrectly()
        {
            this.storageMaster.RegisterStorage("Warehouse", "NewWHouse");

            this.storageMaster.SelectVehicle("NewWHouse", 1);

            Assert.AreEqual(this.storageMaster.SelectVehicle("NewWHouse", 1)
                , $"Selected Semi");
        }

        [Test]
        public void SendVehicleTo_ShouldWorkCorrectly()
        {
            this.storageMaster.RegisterStorage("Warehouse", "FirstStorage");
            this.storageMaster.RegisterStorage("Warehouse", "SecondStorage");

            Assert.AreEqual($"Sent Semi to SecondStorage (slot 3)",
                this.storageMaster
                .SendVehicleTo("FirstStorage", 1, "SecondStorage"));
        }
    }
}