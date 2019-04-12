namespace Tests
{
    using NUnit.Framework;
    using P04.StorageMaster.Entities.Products;
    using P04.StorageMaster.Entities.Storage;
    using P04.StorageMaster.Entities.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class StorageTests
    {
        private Type type;
        private PropertyInfo[] properties;
        private MethodInfo[] methods;

        [SetUp]
        public void Setup()
        {
            this.type = typeof(Storage);

            this.properties = type
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);

            this.methods = type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance);
        }

        [Test]
        public void StorageClass_ShouldBeAbstract()
        {
            Assert.That(this.type.IsAbstract,
                "Class Storage is not abstract!");
        }

        [Test]
        public void Storage_ShouldHavePrivateReadonlyArrayOfVehicles()
        {
            FieldInfo[] fields = this.type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo field = fields.First(f => f.Name == "garage");

            Assert.AreEqual(field.FieldType, typeof(Vehicle[]),
                "Class Storage doesn't have array of vehicles field!");
            Assert.That(field.IsInitOnly,
                "The vehicle list is not read only!");
        }

        [Test]
        public void Storage_ShouldHavePrivateReadonlyListOfProducts()
        {
            FieldInfo[] fields = this.type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo field = fields.First(f => f.Name == "products");

            Assert.AreEqual(field.FieldType, typeof(List<Product>),
                "Class Storage doesn't have list of product field!");
            Assert.That(field.IsInitOnly,
                "The product list is not read only!");
        }

        [Test]
        public void Storage_ShouldHaveProtectedConstructor()
        {
            ConstructorInfo constructor = this.type
                .GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic)
                .First();

            Assert.That(constructor.IsFamily);
        }

        [Test]
        public void Storage_ShouldHaveNameProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "Name"));
        }

        [Test]
        public void Storage_ShouldHaveCapacityProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "Capacity"));
        }

        [Test]
        public void Storage_ShouldHaveGarageSlotsProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "GarageSlots"));
        }

        [Test]
        public void Storage_IsFullProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "IsFull"));
            Assert.IsTrue(this.properties.First(p => p.Name == "IsFull")
                .PropertyType == typeof(bool),
                "The return type of the property should be Boolean!");
        }

        [Test]
        public void Storage_ShouldHaveGarageGetter()
        {
            Assert.That(this.properties.Any(p => p.Name == "Garage"));
            Assert.IsFalse(this.properties.First(p => p.Name == "Garage").CanWrite,
                "Garage getter isn't readonly");
        }

        [Test]
        public void Storage_ShouldHaveProductsGetter()
        {
            Assert.That(this.properties.Any(p => p.Name == "Products"));
            Assert.IsFalse(this.properties.First(p => p.Name == "Products").CanWrite,
                "Products getter isn't readonly");
        }

        [Test]
        public void Storage_GetVehicleMethod()
        {
            Assert.That(this.methods.Any(p => p.Name == "GetVehicle"));

            Assert.IsTrue(this.methods
                .First(p => p.Name == "GetVehicle")
                .GetParameters()
                .First()
                .ParameterType == typeof(int), 
                "GetVehicle method should expect integer as input parameter!");

            Assert.IsTrue(this.methods
                .First(p => p.Name == "GetVehicle")
                .ReturnType == typeof(Vehicle),
                "The return type of the method should be Vehicle!");
        }

        [Test]
        public void Storage_SendVehicleToMethod()
        {
            Assert.That(this.methods.Any(m => m.Name == "SendVehicleTo"));

            Assert.IsTrue(this.methods
                .First(p => p.Name == "SendVehicleTo")
                .ReturnType == typeof(int),
                "The return type of the method should be integer!");
        }

        [Test]
        public void Storage_UnloadVehicleMethod()
        {
            Assert.That(this.methods.Any(m => m.Name == "UnloadVehicle"));

            Assert.IsTrue(this.methods
                .First(p => p.Name == "UnloadVehicle")
                .ReturnType == typeof(int),
                "The return type of the method should be integer!");
        }

        [Test]
        public void Storage_ShouldHavePrivateprivateInitializeGarageMethod()
        {
            Assert.That(this.type
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Any(m => m.Name == "InitializeGarage"));
        }

        [Test]
        public void Storage_ShouldHavePrivateprivateAddVehicleMethod()
        {
            Assert.That(this.type
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Any(m => m.Name == "AddVehicle"));
        }
    }
}