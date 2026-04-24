using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Лабораторна робота 1 ===");
        Console.WriteLine("Варіант 13\n");

        int[] values = { -43, 75, 63 };

        Console.WriteLine("Лічильник збільшення на 1:");
        foreach (int value in values)
        {
            int result;
            IncrementByOne(value, out result);
            Console.WriteLine($"{value} + 1 = {result}");
        }

        Console.WriteLine("\nОперація відношення = :");

        int[,] pairs =
        {
            { 48, 48 },
            { 69, 78 },
            { 24, 25 }
        };

        for (int i = 0; i < pairs.GetLength(0); i++)
        {
            int a = pairs[i, 0];
            int b = pairs[i, 1];

            bool isEqual = IsEqual(a, b);
            Console.WriteLine($"{a} == {b} -> {isEqual}");
        }
    }

    // Функція інкременту
    static void IncrementByOne(int value, out int result)
    {
        result = value + 1;
    }

    // Функція порівняння
    static bool IsEqual(int a, int b)
    {
        return a == b;
    }
}