void ReturnPointOfIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые параллельны и не пересекаются");
    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * x + b1);
        Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
    }
}

Console.WriteLine("Введите значение переменных");
Double.TryParse(Console.ReadLine(), out double b1);
Double.TryParse(Console.ReadLine(), out double k1);
Double.TryParse(Console.ReadLine(), out double b2);
Double.TryParse(Console.ReadLine(), out double k2);
ReturnPointOfIntersection(b1, k1, b2, k2);
