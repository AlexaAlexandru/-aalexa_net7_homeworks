using System;
namespace Homework_W5_OOP_advanced.Exercise7
{
    public class InvalidRoomStatus : Exception
    {
        public InvalidRoomStatus(string? message) : base(message)
        {
        }
    }
}

