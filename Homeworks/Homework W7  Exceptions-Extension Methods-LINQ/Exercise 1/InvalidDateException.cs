using System;
namespace Homeworks_W7__Exceptions__LINQ__Lambdas.Exercise1
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException(string? message) : base(message)
        {
        }
    }
}

