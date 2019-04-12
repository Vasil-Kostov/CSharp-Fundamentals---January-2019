namespace Skeleton.Tests
{
    using NUnit.Framework;
    using Contracts;
    using FakeObjects;
    using Moq;

    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void HeroShouldGainExperianceWhenTargetDies()
        {
            Hero hero = new Hero("Pesho", new FakeWeapon());
            ITarget target = new FakeTarget();

            hero.Attack(target);

            Assert.That(hero.Experience, Is.EqualTo(10), "Hero doesn't gain experiance!");
        }

        [Test]
        public void HeroShouldGainExperianceWhenTargetDiesMoqTest()
        {
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            fakeWeapon.Setup(w => w.AttackPoints).Returns(10);
            fakeWeapon.Setup(w => w.DurabilityPoints).Returns(15);
            
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(t => t.Health).Returns(0);
            fakeTarget.Setup(t => t.GiveExperience()).Returns(10);
            fakeTarget.Setup(t => t.IsDead()).Returns(true);

            Hero hero = new Hero("Pesho", fakeWeapon.Object);
            hero.Attack(fakeTarget.Object);

            Assert.AreEqual(10, hero.Experience);
        }
    }
}
