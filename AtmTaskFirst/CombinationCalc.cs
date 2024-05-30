namespace ATM;
using System.Collections.Generic;

public class CombinationCalc
{
    private readonly List<int> _nominals;
    private readonly long _targetSum;
    private readonly List<List<int>> _combinations;
    private long _combinationsNumber;

    public CombinationCalc(long targetSum, List<int> nominals)
    {
        this._nominals = nominals;
        this._targetSum = targetSum;
        this._combinationsNumber = 0;
        this._combinations = Calculate();
    }

    public List<List<int>> Calculate()
    {
        var combination = new List<int>();
        var result = new List<List<int>>();

        var stack = new Stack<StackData>();
        stack.Push(new StackData(_nominals, _targetSum, combination));

        while (stack.Count > 0)
        {
            var current = stack.Pop();

            long sum = 0;
            foreach (long value in current.Partial)
            {
                sum += value;
            }

            if (sum == current.Target)
            {
                result.Add(current.Partial);
                _combinationsNumber++;
            }

            if (sum >= current.Target)
            {
                continue;
            }

            for (int i = 0; i < current.Nominals.Count; i++)
            {
                var remaining = new List<int>();
                int n = current.Nominals[i];
                for (int j = i; j < current.Nominals.Count; j++)
                {
                    remaining.Add(current.Nominals[j]);
                }

                var partialRec = new List<int>(current.Partial) { n };

                stack.Push(new StackData(remaining, _targetSum, partialRec));
            }
        }

        return result;
    }

    public long GetCombinationsNumber()
    { 
        return _combinationsNumber;
    }

    public List<List<int>> GetCombinations()
    {
        return _combinations;
    }

    private record StackData(List<int> Nominals, long Target, List<int> Partial);
}