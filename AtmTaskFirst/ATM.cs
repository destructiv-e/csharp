using ATM;

namespace AtmTaskFirst;

public class ATM
{
    private readonly List<int> _nominals;
    private readonly long _sum;
    private List<List<int>> _resultCombination;
    private long _numberOfCombinations;

    public ATM(List<int> nominals, long sum)
    {
        this._nominals = nominals.ToList();
        this._sum = sum;
        CalcAtmCombination(nominals);
    }

    private void CalcAtmCombination(List<int> nominals)
    {
        var calc = new CombinationCalc(_sum, this._nominals);
        _resultCombination = calc.GetCombinations();
        _numberOfCombinations = calc.GetCombinationsNumber();
    }
    
    public List<List<int>> GetResultCombination()
    {
        return _resultCombination;
    }

    public long GetNumberOfCombinations()
    {
        return _numberOfCombinations;
    }
}