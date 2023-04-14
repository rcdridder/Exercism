﻿namespace Exercism.Dictionaries
{
    public static class InternationalCallingConnoisseur
    {
        public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();

        public static Dictionary<int, string> GetExistingDictionary() =>
            new Dictionary<int, string>()
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India"}
            };


        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName) =>
            new Dictionary<int, string>() { { countryCode, countryName } };


        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary.Add(countryCode, countryName);
            return existingDictionary;
        }

        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode) =>
            existingDictionary.ContainsKey(countryCode) ? existingDictionary[countryCode].ToString() : string.Empty;


        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) =>
            existingDictionary.ContainsKey(countryCode);


        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
                existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            string longestName = string.Empty;
            foreach (string countryName in existingDictionary.Values)
            {
                if (countryName.Length > longestName.Length) longestName = countryName;
            }
            return longestName;
        }
    }
}
