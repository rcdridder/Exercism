using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Strings
{
    public static class LogLevels
    {
        public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(':') + 2).Trim();
        public static string LogLevel(string logLine) => logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') - logLine.IndexOf('[')).Trim().ToLower();
        public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
