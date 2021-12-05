namespace AdventOfCode.Shared.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<IList<T>> SlidingWindow<T>(this IEnumerable<T> source, int length = 3)
    {
        var result = new List<T>();
        foreach (var item in source)
        {
            if (result.Count == length)
            {
                result.RemoveAt(0);
            }

            result.Add(item);

            yield return result;
        }
    }
}