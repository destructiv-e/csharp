using AtmTaskFirst;

class Program
{
    static void Main()
    {
        string inputRes;
        List<int> res;
        do
        {
            Console.WriteLine("Введите номиналы через пробел или табуляцию:");
            var input = Console.ReadLine();
            inputRes = input.Replace(".", ",");
            res = NominalsCheck(inputRes);
        } while (res == null);

        Console.WriteLine("Номиналы: " + string.Join(", ", res));

        long resultSum = 0;
        string inputSum;
        long resSum; // Изменено на long, чтобы избежать использования Nullable

        do
        {
            Console.WriteLine("Введите целое положительное число, которое хотите разложить:");
            inputSum = Console.ReadLine();
            resSum = TryParsePositiveInteger(inputSum); // Используем long вместо long?

            if (resSum != 0) // Проверяем, что resSum не равно 0, а не null
            {
                resultSum = resSum;
            }

        } while (resSum == 0); // Проверяем, что resSum равно 0, а не null

        Console.WriteLine($"Целевая сумма: {resultSum}");
        Console.WriteLine("Идёт подсчёт...");

        var atm = new AtmTaskFirst.ATM(res, resultSum);

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
    }

    private static long TryParsePositiveInteger(string strNominals)
    {
        strNominals = strNominals.Trim();

        if (strNominals.Contains(' ') || strNominals.Contains('\t'))
        {
            Console.WriteLine("Ошибка: в середине строки не должно быть пробелов или табуляций. Пожалуйста, введите строку заново.");
            return 0; // Возвращаем 0, если ввод некорректен
        }

        if (double.TryParse(strNominals, out double number))
        {
            if (strNominals.Contains('E') || strNominals.Contains('e'))
            {
                Console.WriteLine($"Некорректное значение: {strNominals}. Введите только целые положительные числа без экспоненциальной нотации. Пожалуйста, введите строку заново.");
                return 0; // Возвращаем 0, если ввод некорректен
            }

            if (number >= 0 && number == (int)number)
            {
                return (int)number;
            }
            else
            {
                Console.WriteLine($"Некорректное значение: {strNominals}. Введите только целые положительные числа. Пожалуйста, введите строку заново.");
                return 0; // Возвращаем 0, если ввод некорректен
            }
        }
        else
        {
            Console.WriteLine($"Некорректное значение: {strNominals}. Это не число. Пожалуйста, введите строку заново.");
            return 0; // Возвращаем 0, если ввод некорректен
        }
    }
    private static List<int> NominalsCheck(string strNominals)
    {
        var validNumbers = new List<int>();
        var nominalsArray = strNominals.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        if (nominalsArray.Length > 0)
        {
            if (nominalsArray[^1] != "0")
            {
                Console.WriteLine("Ошибка: последний элемент должен быть равен 0. Пожалуйста, введите строку заново.");
                return null;
            }

            for (int i = 0; i < nominalsArray.Length - 1; i++)
            {
                if (nominalsArray[i] == "0")
                {
                    Console.WriteLine("Ошибка: 0 не может находиться в середине строки. Пожалуйста, введите строку заново.");
                    return null;
                }

                if (double.TryParse(nominalsArray[i], out double number))
                {
                    if (number >= 0 && number == (int)number && number <= int.MaxValue)
                    {
                        validNumbers.Add((int)number);
                    }
                    else if (number > int.MaxValue)
                    {
                        Console.WriteLine($"Некорректное значение: {nominalsArray[i]}. Число слишком велико. Пожалуйста, введите строку заново.");
                        return null;
                    }
                    else
                    {
                        Console.WriteLine($"Некорректное значение: {nominalsArray[i]}. Введите только целые положительные числа. Пожалуйста, введите строку заново.");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine($"Некорректное значение: {nominalsArray[i]}. Это не число. Пожалуйста, введите строку заново.");
                    return null;
                }
            }
        }
        else
        {
            Console.WriteLine("Ошибка: строка не должна быть пустой. Пожалуйста, введите строку заново.");
            return null;
        }

        var res = validNumbers.OrderBy(n => n).Distinct().ToList();
        return res;
    }
}
