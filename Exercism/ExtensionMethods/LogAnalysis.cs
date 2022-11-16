namespace Exercism.ExtensionMethods
{
    public static class LogAnalysis
    {
        public static string SubstringAfter(this string s, string split) => s.Substring(s.IndexOf(split) + split.Length);
        public static string SubstringBetween(this string s, string firstDelimiter, string secondDelimiter) => s.Substring(s.IndexOf(firstDelimiter) + firstDelimiter.Length, s.IndexOf(secondDelimiter) - s.IndexOf(firstDelimiter) - firstDelimiter.Length);
        public static string Message(this string s) => s.Substring(s.IndexOf(':') + 2);
        public static string LogLevel(this string s) => s.SubstringBetween("[", "]");
    }
}
