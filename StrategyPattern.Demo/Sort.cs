namespace StrategyPattern.Demo;

internal interface ISortStrategy
{
    int[] Sort(int[] inputArray);
}

internal class QuickSort : ISortStrategy
{
    public int[] Sort(int[] inputArray)
    {
        if (inputArray == null || inputArray.Length <= 1) return inputArray;

        var centerIndex = inputArray.Length / 2;
        var centerValue = inputArray[centerIndex];

        var leftPart = new List<int>();
        var rightPart = new List<int>();

        for (var i = 0; i < inputArray.Length; i++)
        {
            if (i == centerIndex) continue;
            if(inputArray[i] <= centerValue)
                leftPart.Add(inputArray[i]);
            else
                rightPart.Add(inputArray[i]);
        }

        var sorted = Sort(leftPart.ToArray()).ToList();
        sorted.Add(centerValue);
        sorted.AddRange(Sort(rightPart.ToArray()));

        return sorted.ToArray();
    }
}
