namespace Exercism.Randomness
{
    public class RollTheDie
    {
        private Random random = new();
        public int RollDie() => random.Next(1, 18);
        public double GenerateSpellStrength() => random.NextDouble() * 100;
    }
}
