namespace MordorsCruelPlan.Factories
{
    using Moods;

    public abstract class MoodFactory
    {
        public static Mood CreateMood(int happinessPoints)
        {
            if (happinessPoints < -5)
            {
                return new Angry();
            }
            else if (happinessPoints >= -5 && happinessPoints <= 0)
            {
                return new Sad();
            }
            else if (happinessPoints >= 1 && happinessPoints <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}
