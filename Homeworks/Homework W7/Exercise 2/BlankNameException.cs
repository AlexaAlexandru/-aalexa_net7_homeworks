using System;
namespace Homeworks_W7.Exercise2
{
    public class BlankNameException : Exception
    {
        public BlankNameException(string? message) : base(message)
        {
        }
    }
}

