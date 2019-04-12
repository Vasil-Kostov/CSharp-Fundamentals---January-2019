namespace Skeleton.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    class DummyTests
    {
        [Test]
        public void DummyLoosesHealthIfAtacked()
        {
            Dummy dummy = new Dummy(10, 10);

            dummy.TakeAttack(1);

            Assert.That(dummy.Health, Is.EqualTo(9), "Dummy doesn't loose health when atacked");
        }

        [Test]
        public void DeadDummyThrowsExceprionIfAtacked()
        {
            Dummy dummy = new Dummy(0, 10);
            
                Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1),
                    "Dead Dummy does't trow exception if attacked!");
        }

        [Test]
        public void DeadDummyGivesExperience()
        {
            Dummy dummy = new Dummy(0, 10);

            int XP = dummy.GiveExperience();

            Assert.That(XP.Equals(10), "Dead dummy doesn't gives experinace!");
        }

        [Test]
        public void AliveDummyDoesntGivesExperienceExceprion()
        {
            Dummy dummy = new Dummy(10, 10);
            
                Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(),
                    "Alive Dummy gives experiance!");
        }
    }
}
