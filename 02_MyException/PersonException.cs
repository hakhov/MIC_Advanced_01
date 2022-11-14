public class PersonException : Exception
{
    public int Value { get; }
    public PersonException()
    {
    }

    public PersonException(string? message) : base(message)
    {
    }
    public PersonException(string? message, int val) : base(message)
    {
        Value = val;
    }
}