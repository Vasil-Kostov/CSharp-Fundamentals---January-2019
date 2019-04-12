namespace Tests
{
    using NUnit.Framework;
    using P04.StorageMaster.Entities.Products;
    using P04.StorageMaster.Entities.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class VehicleTests
    {
        private Type type;
        private PropertyInfo[] properties;
        private MethodInfo[] methods;

        [SetUp]
        public void Setup()
        {
            this.type = typeof(Vehicle);

            this.properties = type
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);

            this.methods = type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance);
        }

        [Test]
        public void VehicleClass_ShouldBeAbstract()
        {
            Assert.That(this.type.IsAbstract, 
                "Class vehicle is not abstract!");
        }

        [Test]
        public void Vehicle_ShouldHavePrivateReadonlyListOfProducts()
        {
            FieldInfo[] fields = this.type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo field = fields.First();
                        
            Assert.AreEqual(field.FieldType, typeof(List<Product>),
                "Class vehicle doesn't have list of product field!");
            Assert.That(field.IsInitOnly, 
                "The product list is not read only!");
        }

        [Test]
        public void Vehicle_ShouldHaveProtectedConstructor()
        {
            ConstructorInfo constructor = this.type
                .GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic)
                .First();

            Assert.That(constructor.IsFamily);
        }

        [Test]
        public void Vehicle_ShouldHaveCapacityProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "Capacity"));
        }

        [Test]
        public void Vehicle_ShouldHaveTrunkGetter()
        {
            Assert.That(this.properties.Any(p => p.Name == "Trunk"));
            Assert.IsFalse(this.properties.First(p => p.Name == "Trunk").CanWrite, 
                "Trunk getter isn't readonly");
        }

        [Test]
        public void Vehicle_IsFullProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "IsFull"));
            Assert.IsTrue(this.properties.First(p => p.Name == "IsFull")
                .PropertyType == typeof(bool),
                "The return type of the property should be Boolean!");
        }

        [Test]
        public void Vehicle_IsEmptyProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "IsEmpty"));
            Assert.IsTrue(this.properties.First(p => p.Name == "IsEmpty")
                .PropertyType == typeof(bool),
                "The return type of the property should be Boolean!");
        }

        [Test]
        public void Vehicle_LoadProductMethod()
        {
            Assert.That(this.methods.Any(p => p.Name == "LoadProduct"));
            Assert.That(this.methods.First(p => p.Name == "LoadProduct")
                .GetParameters()
                .First()
                .ParameterType == typeof(Product),
                "LoadProduct method should expect product!");
        }

        [Test]
        public void Vehicle_UnloadMethod()
        {
            Assert.That(this.methods.Any(p => p.Name == "Unload"));
            Assert.IsTrue(this.methods
                .First(p => p.Name == "Unload")
                .ReturnType == typeof(Product),
                "The return type of the method should be Product!");
        }
    }
}