namespace Exercism.Tuples
{
    public static class PhoneNumberAnalysis
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string[] sections = phoneNumber.Split('-');
            return (sections[0] == "212", sections[1] == "555", sections[2]);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake ? true : false;

    }
}
