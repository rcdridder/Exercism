namespace Exercism.Sets
{
    public class RobotNameSets
    {
        public RobotNameSets() => Reset();

        public string Name { get; private set; }

        public void Reset()
        {
            string proposedName = CreateName();
            while (usedNames.Contains(proposedName))
                proposedName = CreateName();
            usedNames.Add(proposedName);
            Name = proposedName;
        }

        private string CreateName()
        {
            Random rng = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUWVXYZ";
            string numbers = "0123456789";
            char[] randomName =
            {
                    alphabet[rng.Next(0, alphabet.Length)],
                    alphabet[rng.Next(0, alphabet.Length)],
                    numbers[rng.Next(0, numbers.Length)],
                    numbers[rng.Next(0, numbers.Length)],
                    numbers[rng.Next(0, numbers.Length)]
            };
            return new string(randomName);
        }

        private static List<string> usedNames = new();
    }
}
