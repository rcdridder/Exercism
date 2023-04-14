namespace Exercism.Nullability
{
    public static class TimFromMarketing
    {
        public static string Print(int? id, string name, string? department)
        {
            string output = string.Empty;
            if (id != null)
                output += $"[{id}] - ";
            output += $"{name} - ";
            if (department == null)
                output += "OWNER";
            else
                output += $"{department.ToUpper()}";
            return output;
        }
    }
}
