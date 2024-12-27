using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива (через пробел):");
        float[] array = Console.ReadLine()
            .Split(' ')
            .Select(float.Parse)
            .ToArray();

        Console.WriteLine("Введите число:");
        float number = float.Parse(Console.ReadLine());

        List<float> result = array.Where(x => (x % number) > 0.2f).ToList();

        Console.WriteLine("Результат: " + string.Join(", ", result));
    }
}
