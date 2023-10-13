namespace Exercism.IntegralNumbers
{
    public static class HyperOptimizedTelemetry
    {
        public static byte[] ToBuffer(long reading)
        {
            byte[] input = BitConverter.GetBytes(reading);
            byte[] output = new byte[input.Length + 1];

            switch (reading)
            {
                case var _ when reading < int.MinValue:
                    output[0] = 256 - 8;
                    for (int i = 8; i < input.Length; i++) input[i] = 0;
                    break;
                case var _ when reading < short.MinValue:
                    output[0] = 256 - 4;
                    for (int i = 4; i < input.Length; i++) input[i] = 0;
                    break;
                case var _ when reading < ushort.MinValue:
                    output[0] = 256 - 2; input[2] = 0;
                    for (int i = 2; i < input.Length; i++) input[i] = 0;
                    break;
                case var _ when reading <= ushort.MaxValue: output[0] = 2; break;
                case var _ when reading <= int.MaxValue: output[0] = 256 - 4; break;
                case var _ when reading <= uint.MaxValue: output[0] = 4; break;
                default: output[0] = 256 - 8; break;
            }
            for (int i = 1; i < output.Length; i++)
                output[i] = input[i - 1];
            return output;
        }

        public static long FromBuffer(byte[] buffer)
        {
            switch (buffer[0])
            {
                case 248: case 4: case 2: return BitConverter.ToInt64(buffer, 1);
                case 252: return BitConverter.ToInt32(buffer, 1);
                case 254: return BitConverter.ToInt16(buffer, 1);
                default: return 0;
            }
        }
    }
}
