namespace ATM;

using System;
using System.Collections.Generic;
using System.Linq;

public class ATM
{
    private readonly List<int> nominals;
    private readonly long sum;
    private List<List<int>> resultCombination;
    private long numberOfCombinations;

    public ATM(int[] nominals, long sum)
    {
        this.nominals = nominals.ToList();
        this.sum = sum;
        CalcAtmCombination(nominals);
    }

    private void CalcAtmCombination(int[] nominals)
    {
        NominalsCheck(nominals);
        var calc = new CombinationCalc(sum, this.nominals);
        resultCombination = calc.GetCombinations();
        numberOfCombinations = calc.GetCombinationsNumber();
    }

    private void NominalsCheck(int[] nominals)
    {
        var nominalsList = nominals.OrderBy(n => n).Distinct().ToList();
        foreach (var nominal in nominalsList)
        {
            if (nominal < 0)
            {
                throw new ArgumentException("Некорректные данные: массив номиналов содержит отрицательные значения");
            }
        }

        if (sum <= 0)
        {
            throw new ArgumentException("Некорректные данные: целевая сумма должна быть больше 0");
        }

        if (!nominalsList.Any())
        {
            throw new ArgumentException("Некорректные данные: массив номиналов пуст");
        }
    }
    
    public List<List<int>> GetResultCombination()
    {
        return resultCombination;
    }

    public long GetNumberOfCombinations()
    {
        return numberOfCombinations;
    }
}