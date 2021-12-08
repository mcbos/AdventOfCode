﻿var stopwatch = new Stopwatch();
var challenge = new Day09();

Console.WriteLine(challenge);

stopwatch.Start();

var day = 9;
var part = 1;
var answer = await challenge.ExecuteAsync(part);

Console.WriteLine($"Part {part}: {answer} in {stopwatch.Elapsed}");

await AocApi.PostAnswer(day, part, answer);

// Part 2
stopwatch.Restart();

part = 2;
answer = await challenge.ExecuteAsync(part);

Console.WriteLine($"Part {part}: {answer} in {stopwatch.Elapsed}");

await AocApi.PostAnswer(day, part, answer);