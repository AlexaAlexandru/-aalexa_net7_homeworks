using System;
namespace Homework_W5_OOP_advanced.Exercise7
{
	public class Booking
	{
		public Guid Id { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
		public Client Client {  get; private set; }
		public Room Room {  get; private set; }

		public Booking(Client client, Room room, DateTime checkIn, DateTime checkOut)
		{
			Id = Guid.NewGuid();
			CheckIn = checkIn;
			CheckOut = checkOut;
			Client = client;
			Room = room;
		}

        public double GetNumberOfNights()
        {
            double numberNights = (CheckOut - CheckIn).Days;
            return numberNights;
        }

		public double GetFinalPrice()
		{
			return GetNumberOfNights() * Room.Price;
		}

    }
}

