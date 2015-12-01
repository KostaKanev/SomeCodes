using System;

public class NegativeNumberException : Exception
{
    public NegativeNumberException() : base("The number must be positive.")
    {
    }

    public NegativeNumberException(string message) : base(message)
    {
    }
}