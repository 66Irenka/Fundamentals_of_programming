namespace Fundamentals_of_programming;

public class TextContainer
{
    private readonly List<MyString> texts = new List<MyString>();

    public void Add(string value)
    {
        texts.Add(new MyString(value));
    }

    public void Remove(string value)
    {
        texts.RemoveAll(t => t.Value == value);
    }

    public void Clear()
    {
        texts.Clear();
    }

    public MyString? GetLongest()
    {
        if (texts.Count == 0)
        {
            return null;
        }

        MyString longest = texts[0];

        foreach (MyString text in texts)
        {
            if (text.Length() > longest.Length())
            {
                longest = text;
            }
        }

        return longest;
    }

    public int GetTotalLength()
    {
        int total = 0;

        foreach (MyString text in texts)
        {
            total += text.Length();
        }

        return total;
    }

    public double GetDigitsPercentage()
    {
        int totalChars = 0;
        int totalDigits = 0;

        foreach (MyString text in texts)
        {
            totalChars += text.Length();
            totalDigits += text.CountDigits();
        }

        if (totalChars == 0)
        {
            return 0;
        }

        return (double)totalDigits / totalChars * 100;
    }

    public void PrintAll()
    {
        foreach (MyString text in texts)
        {
            Console.WriteLine(text);
        }
    }
}