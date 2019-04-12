namespace Skeleton.FakeObjects
{
    using Skeleton.Contracts;

    public class FakeTarget : ITarget
    {
        public int Health { get; private set; } = 0;

        public int GiveExperience() => 10;

        public bool IsDead() => true;

        public void TakeAttack(int attackPoints)
        {
            this.Health -= attackPoints;
        }
    }
}
