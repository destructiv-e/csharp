var numberList = new List<int>();
Console.WriteLine("Задача 1 \n Банкомат \n");
//int numbNomin = Convert.ToInt32(Console.ReadLine());
//int[] nomin = new int[numbNomin];
Console.WriteLine("Введите номиналы");
string strNominals = Console.ReadLine();
string[] linesArr = strNominals.Split(' ');
foreach (var token in linesArr)
{
    if (token == "0")
    {
        break;
    }

    if (int.TryParse(token, out int number))
    {
        numberList.Add(number);
    }
    else
    {
        Console.WriteLine("Строка введена некорректно");
    }
}

//for (int i = 0; i < nomin.Length; i++)
//{
//    Console.Write("Введите элемент {0}: ", i);
//    nomin[i] = int.Parse(Console.ReadLine());
//        
//}
Console.Write("Введите целевую сумму: ");
int sum = Convert.ToInt32(Console.ReadLine());
var atm = new ATM.ATM(numberList.ToArray(), sum);

if (atm.GetNumberOfCombinations() == 0)
{
    Console.WriteLine("Количество комбинаций равно 0");
}
else
{
    Console.WriteLine("Количество комбинаций: " + atm.GetNumberOfCombinations());
    Console.WriteLine("\n Комбинации: \n");
    foreach (List<int> resultCombination in atm.GetResultCombination())
    {
        foreach (int number in resultCombination)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
Console.ReadLine();