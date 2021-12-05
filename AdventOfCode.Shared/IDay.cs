namespace AdventOfCode.Shared;

public interface IDay
{
    object Input { get; set; }

    object ParseInput(string raw);

    Task<object> ExecuteAsync(int part, CancellationToken cancellationToken = default);
}
