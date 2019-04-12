namespace Tests
{
    using NUnit.Framework;
    using P04.StorageMaster.Entities.Products;
    using System;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    class ProductTests
    {
        private Type type;
        private PropertyInfo[] properties;
        private MethodInfo[] methods;

        [SetUp]
        public void Setup()
        {
            this.type = typeof(Product);

            this.properties = type
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        [Test]
        public void ProductClass_ShouldBeAbstract()
        {
            Assert.That(this.type.IsAbstract,
                "Class Storage is not abstract!");
        }

        [Test]
        public void Product_ShouldHavePrivatePrice()
        {
            FieldInfo[] fields = this.type
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo field = fields.First(f => f.Name == "price");
        }

        [Test]
        public void Product_ShouldHaveProtectedConstructor()
        {
            ConstructorInfo constructor = this.type
                .GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic)
                .First();

            Assert.That(constructor.IsFamily);
        }

        [Test]
        public void Product_ShouldHavePriceProperty()
        {
            Assert.That(this.properties.Any(p => p.Name == "Price"));
        }

        [Test]
        public void Product_ShouldHaveWeightGetter()
        {
            Assert.That(this.properties.Any(p => p.Name == "Weight"));
            Assert.IsFalse(this.properties.First(p => p.Name == "Weight")
                .CanWrite,
                "Garage getter isn't readonly");
        }
    }
}
