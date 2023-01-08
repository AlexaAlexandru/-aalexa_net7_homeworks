using System;
using System.Drawing;

namespace Homework_W5_OOP_advanced.Exercise7
{
	public abstract class Room
	{
		public Guid Id { get; set; }
		public int Number { get; set; }
		public int Floor { get; set; }
		public int BedRooms { get; set; }
		public double Price { get; set; }
		public Status StatusRoom { get; private set; }

        protected Room(int number, int floor)
        {
            Id = Guid.NewGuid();
			Number = number;
            Floor = floor;
        }

        public override string ToString()
        {
            return $"{Id} - {Number} - {Floor} - {BedRooms} - {StatusRoom}";
        }


        public void BookRoom()
		{
			StatusRoom = Status.Booked;
		}

		public Status ClearRoom()
		{
			return Status.Available;
		}

		public string RoomType()
		{
			string message = string.Empty;
            return this.GetType().Name;
        }

	}
}

