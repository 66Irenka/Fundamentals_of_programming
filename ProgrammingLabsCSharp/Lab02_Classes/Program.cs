using Fundamentals_of_programming;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Лабораторна робота 2 ===");
        Console.WriteLine("Варіант 13\n");

        TextContainer container = new TextContainer();

        container.Add("Hello123");
        container.Add("World");
        container.Add("CSharp2026");

        Console.WriteLine("Початковий текст:");
        container.PrintAll();

        Console.WriteLine($"\nНайбільший рядок: {container.GetLongest()}");
        Console.WriteLine($"Загальна кількість символів: {container.GetTotalLength()}");
        Console.WriteLine($"Відсоток символів-цифр: {container.GetDigitsPercentage():F2}%");

        container.Remove("World");

        Console.WriteLine("\nПісля видалення рядка 'World':");
        container.PrintAll();

        container.Clear();

        Console.WriteLine("\nПісля очищення тексту:");
        container.PrintAll();

        Console.WriteLine("Текст очищено.");
    }
}