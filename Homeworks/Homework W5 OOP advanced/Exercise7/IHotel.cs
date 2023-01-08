using System;
namespace Homework_W5_OOP_advanced.Exercise7
{
	public interface IHotel
	{
		void RegisterClient(string cnp, string firstName, string lastName, string email, string phone);

		void RemoveClient(string CNP);

		void AddSingleRoom(int number, int floor);

		void AddDoubleRoom(int number, int floor);

		void AddLuxuryRoom(int number, int floor);

		void UpdteRoomPrice(int roomNumber, double price);

		void ShowAllRooms();

		void AddBooking(string CNP, int number, DateTime checkIn, DateTime checkOut);

		void AllBookings();

		void ActiveBooking();

		void ClearBookingId(string CNP);

    }
}

