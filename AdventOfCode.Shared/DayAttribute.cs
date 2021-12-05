namespace AdventOfCode.Shared;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class DayAttribute : Attribute
{
    public DayAttribute(int year, int day)
    {
        Year = year;
        Day = day;
    }

    public int Year { get; }
    public int Day { get; }
}
