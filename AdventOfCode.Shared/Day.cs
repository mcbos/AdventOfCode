using System.Reflection;

namespace AdventOfCode.Shared;

public abstract class Day : Day<string>
{
    public override string ParseInput(string raw) => raw;
}

public abstract class Day<T> : IDay
{
    public virtual T Input { get; set; } = default!;
    object IDay.Input { get => Input!; set => Input = (T)value; }

    public Day()
    {
        var attribute = GetType().GetCustomAttribute<DayAttribute>() ?? throw new ArgumentNullException("DayAttribute");

        Input = ParseInput(File.ReadAllText($@"Inputs{Path.DirectorySeparatorChar}{attribute.Day}.txt"));
    }

    public abstract T ParseInput(string raw);
    object IDay.ParseInput(string raw) => ParseInput(raw)!;

    public async Task<object> ExecuteAsync(int part, CancellationToken cancellationToken = default) =>
        part switch
        {
            1 => await ExecutePart1Async(cancellationToken),
            2 => await ExecutePart2Async(cancellationToken),
            _ => throw new ArgumentOutOfRangeException(nameof(part), "")
        };

    public virtual object ExecutePart1() => throw new NotImplementedException();

    public virtual object ExecutePart2() => throw new NotImplementedException();

    private Task<object> ExecutePart1Async(CancellationToken cancellationToken = default) => Task.Factory.StartNew(ExecutePart1, cancellationToken);

    private Task<object> ExecutePart2Async(CancellationToken cancellationToken = default) => Task.Factory.StartNew(ExecutePart2, cancellationToken);
}