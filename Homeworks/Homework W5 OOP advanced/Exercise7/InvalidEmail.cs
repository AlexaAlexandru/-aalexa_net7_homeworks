using System;
namespace Homework_W5_OOP_advanced.Exercise7
{
    public class InvalidEmail : Exception
    {
        public InvalidEmail(string? message) : base(message)
        {
        }
    }
}

