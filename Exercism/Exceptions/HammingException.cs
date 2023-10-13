namespace Exercism.Exceptions
{
    public static class HammingException
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            int distance = 0;
            if (firstStrand == string.Empty && secondStrand == string.Empty)
                return distance;
            if (firstStrand == string.Empty || secondStrand == string.Empty || firstStrand.Length != secondStrand.Length)
                throw new ArgumentException();
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                    distance++;
            }
            return distance;
        }
    }
}
