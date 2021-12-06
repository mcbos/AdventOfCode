var stopwatch = new Stopwatch();
IDay challenge = new Day05();

Console.WriteLine(challenge);

stopwatch.Start();

var day = 5;
var part = 1;
var answer = await challenge.ExecuteAsync(part);

Console.WriteLine($"Part {part}: {answer} in {stopwatch.Elapsed}");

await AocApi.PostAnswer(day, part, answer);

// Part 2
challenge = new Day05(); // reset Input

stopwatch.Restart();

part = 2;
answer = await challenge.ExecuteAsync(part);

Console.WriteLine($"Part {part}: {answer} in {stopwatch.Elapsed}");

await AocApi.PostAnswer(day, part, answer);