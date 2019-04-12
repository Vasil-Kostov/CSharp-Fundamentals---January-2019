namespace Tests
{
    using NUnit.Framework;
    using P03.CustomLinkedList;
    using System;

    [TestFixture]
    public class Tests
    {
        private DynamicList<int> list;

        [SetUp]
        public void Setup()
        {
            this.list = new DynamicList<int>();
            int[] nums = new int[] { 1, 2, 3 };
            for (int i = 0; i < nums.Length; i++)
            {
                this.list.Add(nums[i]);
            }
        }

        [Test]
        public void AddMethod_ShouldAddAllElements()
        {
            Assert.That(this.list.Count.Equals(3),
                "Add method doesn't work correctly!");
        }

        [Test]
        public void Count_ShoudWorkCorrectly()
        {
            Assert.That(this.list.Count.Equals(3),
                "Count doesn't work correctly");
        }

        [Test]
        public void GetElement_ShoudWorkCorrectly()
        {
            Assert.That(this.list[2].Equals(3),
                "Getter doesn't work correctly");
        }

        [Test]
        [TestCase(-1)]
        [TestCase(3)]
        public void GetElement_ShoudThrowExeptionIfIndexIsInvalid(int index)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => { int num = this.list[index]; },
                "Getter doesn't throw expected exception");
        }

        [Test]
        public void SetElement_ShoudWorkCorrectly()
        {
            this.list[2] = 4;

            Assert.That(this.list[2].Equals(4),
                "Setter doesn't work correctly");
        }

        [Test]
        [TestCase(-1)]
        [TestCase(3)]
        public void SetElement_ShoudThrowExeptionIfIndexIsInvalid(int index)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => {this.list[index] = 4; },
                "Setter doesn't throw expected exception");
        }

        [Test]
        public void RemoveAtMethod_ShouldRemoveTheCorrectElement()
        {
            int number = list.RemoveAt(1);

            Assert.That(number.Equals(2),
                "RemoveAt method doesn't return correctly!");
        }

        [Test]
        [TestCase(-1)]
        [TestCase(3)]
        public void RemoveAtMethod_ShouldThrowExceptinIfIndexIsIncorrect(int index)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.list.RemoveAt(index),
                "RemoveAt method doesn't throw the expected exception!");
        }

        [Test]
        public void RemoveMethod_ShouldReturnCorrectIndex()
        {
            int number = list.Remove(2);

            Assert.That(number.Equals(1),
                "RemoveAt method doesn't return the correct index!");
        }

        [Test]
        public void RemoveMethod_ShouldReturnMinsOneIfElementIsNotFound()
        {
            int number = list.Remove(4);

            Assert.That(number.Equals(-1),
                "RemoveAt method doesn't return the correct index!");
        }

        [Test]
        public void IndexOf_ShouldReturnCorrectIndex()
        {
            int number = list.Remove(2);

            Assert.That(number.Equals(1),
                "IndexOf method doesn't return the correct index!");
        }

        [Test]
        public void IndexOf_ShouldReturnMinsOneIfElementIsNotFound()
        {
            int number = list.Remove(4);

            Assert.That(number.Equals(-1),
                "IndexOf method doesn't return the correct index!");
        }
    }
}