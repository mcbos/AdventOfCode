var stopwatch = new Stopwatch();
IDay challenge = new Day05();

Console.WriteLine(challenge);

stopwatch.Start();
Console.Write($"Part 1: {await challenge.ExecuteAsync(1)}");
Console.WriteLine($" in {stopwatch.Elapsed}");

stopwatch.Restart();
Console.Write($"Part 2: {await challenge.ExecuteAsync(2)}");
Console.WriteLine($" in {stopwatch.Elapsed}");
