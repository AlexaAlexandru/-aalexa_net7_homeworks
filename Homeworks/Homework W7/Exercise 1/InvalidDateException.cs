using System;
namespace Homeworks_W7.Exercise1;

public class InvalidDateException : Exception
{
    public InvalidDateException(string? message) : base(message)
    {
    }
}

