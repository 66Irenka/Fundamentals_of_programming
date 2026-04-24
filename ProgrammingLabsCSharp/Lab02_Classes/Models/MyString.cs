namespace Fundamentals_of_programming;

public class MyString
{
    public string Value { get; set; }

    public MyString(string value)
    {
        Value = value;
    }

    public int Length()
    {
        return Value.Length;
    }

    public int CountDigits()
    {
        int count = 0;

        foreach (char c in Value)
        {
            if (char.IsDigit(c))
            {
                count++;
            }
        }

        return count;
    }

    public override string ToString()
    {
        return Value;
    }
}