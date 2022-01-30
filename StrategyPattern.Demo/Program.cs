using StrategyPattern.Demo;

var items = new[] { 88, 54, 34, 87, 15, 8, 105 };

var sortedNumbers = new SortedNumbers(new BubbleSort());
sortedNumbers.Sort(items);

Console.WriteLine("======================");

sortedNumbers = new SortedNumbers(new QuickSort());
sortedNumbers.Sort(items);