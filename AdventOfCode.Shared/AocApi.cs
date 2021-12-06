namespace AdventOfCode.Shared;

public static class AocApi
{
    private static readonly string? cookie = Environment.GetEnvironmentVariable("AOC_COOKIE");

    public static async Task PostAnswer(int day, int part, object answer)
    {
        if (answer == null || cookie == null) return;

        var client = new HttpClient() { BaseAddress = new Uri("https://adventofcode.com/") };
        client.DefaultRequestHeaders.Add("Cookie", $"session={cookie}");

        var _ = (await client.PostAsync($"/2021/day/{day}/answer", new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["level"] = $"{part}",
            ["answer"] = answer.ToString()!
        }!), CancellationToken.None)).EnsureSuccessStatusCode();
    }
}
