using System;
namespace Homeworks_W7__Exceptions__LINQ__Lambdas.Exercise2
{
    public class BlankNameException : Exception
    {
        public BlankNameException(string? message) : base(message)
        {
        }
    }
}

