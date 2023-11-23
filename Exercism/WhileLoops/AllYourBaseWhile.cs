namespace Exercism.WhileLoops
{
    public static class AllYourBaseWhile
    {
        public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
        {
            if (inputBase < 2 || outputBase < 2 || Array.Exists(inputDigits, i => i < 0) || Array.Exists(inputDigits, i => i >= inputBase))
                throw new ArgumentException();

            if (inputDigits == null || inputDigits.Length == 0)
                return new int[] { 0 };

            //Convert input to denary number
            int denaryValue = 0;
            int multiplier = inputBase;
            int inputSize = inputDigits.Length - 1;

            denaryValue += inputDigits[inputSize];
            inputSize--;
            for (int i = inputSize; i >= 0; i--)
            {
                denaryValue += inputDigits[i] * multiplier;
                multiplier *= inputBase;
            }

            //Calculate output array size
            int outputLength = 0;
            int sum = 1;
            while (sum < denaryValue)
            {
                outputLength++;
                sum *= outputBase;
            }

            int[] output;
            if (outputLength == 0)
                output = new int[1];
            else
                output = new int[outputLength];

            //Convert denary number to output
            int result = denaryValue;
            int remainder = 0;
            for (int i = output.Length - 1; i >= 0; i--)
            {
                remainder = result % outputBase;
                output[i] = remainder;
                result /= outputBase;
            }
            return output;
        }
    }
}
