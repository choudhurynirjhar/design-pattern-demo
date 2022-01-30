namespace StrategyPattern.Demo;

internal interface ISortedNumbers
{
    void Sort(int[] items);
}

internal class SortedNumbers : ISortedNumbers
{
    private readonly ISortStrategy sortStrategy;

    public SortedNumbers(ISortStrategy sortStrategy)
    {
        this.sortStrategy = sortStrategy;
    }

    public void Sort(int[] items)
    {
        var sorted = sortStrategy.Sort(items);
        foreach (var item in sorted)
            Console.WriteLine(item);
    }
}