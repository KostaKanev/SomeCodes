using System;

public class OutOfRangeException : Exception
{
    public OutOfRangeException() : base("Number is out of range.")
    {
    }

    public OutOfRangeException(string message) : base(message)
    {
    }
}