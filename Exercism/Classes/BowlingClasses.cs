namespace Exercism.Classes
{
    public class BowlingClasses
    {
        int frameCount = 0;
        bool lastRoll = false;
        List<Frame> frames = new();

        public BowlingClasses()
        {
            for (int i = 0; i < 10; i++)
                frames.Add(new Frame());
        }

        public void Roll(int pins)
        {
            if (frameCount > 9)
                throw new ArgumentException();

            frames[frameCount].isOpen = true;
            foreach (Frame f in frames)
            {
                if (f.isOpen)
                    f.ProcessRoll(pins);
            }

            if (frameCount == 9)
            {
                if (frames.Where(f => !f.isOpen).Count() == frames.Count)
                    frameCount++;
                return;
            }

            if (pins == 10 || lastRoll)
            {
                frameCount++;
                lastRoll = false;
            }
            else
                lastRoll = true;
        }

        public int? Score()
        {
            int score = 0;
            if (frameCount != 10)
                throw new ArgumentException();
            foreach (Frame f in frames)
            {
                score += f.Score;
            }
            return score;
        }
    }

    public class Frame
    {
        int rollCount = 0;
        int remPins = 10;
        public bool isOpen = false;
        public int Score = 0;

        public void ProcessRoll(int pins)
        {
            if (pins < 0)
                throw new ArgumentException();
            rollCount++;
            remPins -= pins;

            if (rollCount == 1)
            {
                if (remPins < 0)
                    throw new ArgumentException();
                else if (remPins == 0) //Strike
                {
                    Score += pins;
                    remPins = 10;
                    return;
                }
                else
                {
                    Score += pins;
                    return;
                }
            }
            if (rollCount == 2)
            {
                if (remPins < 0)
                    throw new ArgumentException();
                else if (remPins == 0) //Spare or bonus strike
                {
                    Score += pins;
                    remPins = 10;
                    return;
                }
                else if (Score == 10) //Bonus roll 1 after strike
                {
                    Score += pins;
                    return;
                }
                else
                {
                    Score += pins;
                    isOpen = false;
                    return;
                }
            }
            if (rollCount == 3)
            {
                if (remPins < 0)
                    throw new ArgumentException();
                else
                {
                    Score += pins;
                    isOpen = false;
                    return;
                }
            }
        }
    }
}