namespace AdventOfCode.Shared.Extensions;

public static class StringExtensions
{
    public static IEnumerable<T> AsCsv<T>(this string line, char seperator = ',', StringSplitOptions options = StringSplitOptions.None) =>
        line.Split(seperator, options).Select(x => (T)Convert.ChangeType(x, typeof(T))).ToList();
}
