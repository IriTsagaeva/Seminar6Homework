int ReturnPositiveElementsNumber()
{
    Console.WriteLine("Пожалуйста, введите число:");
    bool text = Int32.TryParse(Console.ReadLine(), out int intNumber);
    if (!text)
    {
        return 0;
    }
    else if (intNumber > 0)
    {
        return 1 + ReturnPositiveElementsNumber();
    }
    else
    {
        return ReturnPositiveElementsNumber();
    }
}

Console.Clear();
Console.WriteLine("Пожалуйста, введите числа. Для окончания ввода введите любой отличный от числа символ:");
Console.WriteLine($"Количество введенных положительных элементов равно {ReturnPositiveElementsNumber()}.");
