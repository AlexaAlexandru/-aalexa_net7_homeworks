using System;
namespace Homework_W5_OOP_advanced.Exercise7
{
	public static class HotelMain
	{
        public static void Run()
        {
            while (true)
            {
                MenuHotel();

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        GenerateHotel();

                        break;

                    case 2:

                        GenerateClientData(GenerateHotel());
                        
                        break;

                    case 3:

                        RemoveTheClient(GenerateHotel());

                        break;

                    case 4:

                        AddTheSingleRoom(GenerateHotel());

                        break;

                    case 5:

                        AddTheDoubleRoom(GenerateHotel());

                        break;

                    case 6:

                        AddTheLuxuryRoom(GenerateHotel());
                        break;

                    case 7:

                        UpdateTheRoomPrice(GenerateHotel());
                        break;

                    case 8:

                        ShowAllTheRooms(GenerateHotel());
                        break;

                    case 9:

                        AddABooking(GenerateHotel());
                        break;

                    case 10:

                        ShowAllBookings(GenerateHotel());
                        break;

                    case 11:

                        ShowActiveBookings(GenerateHotel());
                        break;

                    case 12:

                        ClearBooking(GenerateHotel());
                        break;
                }
                if(option == 0)
                {
                    break;
                }
               
            }
        }

        public static void MenuHotel()
        {
            Console.WriteLine($"Welcome");
            Console.WriteLine("Choose from menu:");
            Console.WriteLine("1. Register Hotel");
            Console.WriteLine("2. Register client");
            Console.WriteLine("3. Remove client ");
            Console.WriteLine("4. Add Single room");
            Console.WriteLine("5. Add Double room");
            Console.WriteLine("6. Add Luxury room");
            Console.WriteLine("7. Update room price");
            Console.WriteLine("8. Show all rooms");
            Console.WriteLine("9. Add Booking");
            Console.WriteLine("10. Show all bookings");
            Console.WriteLine("11. Show active bookings");
            Console.WriteLine("12. Clear booking ");
            Console.WriteLine(" 0. Exist the program ");

        }

        public static void ShowAvailableRooms(Hotel hotel)
        {
            var availableRooms = hotel.GetAvailableRooms(DateTime.Now,DateTime.Now.AddDays(4));
            foreach (var availableRoom in availableRooms)
            {
                Console.WriteLine(availableRoom);
            }
        }

        public static Hotel GenerateHotel()
        {
            Console.WriteLine("Please insert hotel name");
            string inputHotelName = Console.ReadLine();
            Console.WriteLine("Please insert the hotel's location");
            string inputHotelLocation = Console.ReadLine();
            Console.WriteLine("Please insert the hotel's postal code");
            int inputHotelPostalCode = Convert.ToInt32(Console.ReadLine());

            Hotel hotel = new Hotel()
            {
                HotelName = inputHotelName,
                Location = inputHotelLocation,
                PostalCode = inputHotelPostalCode
            };

            return hotel;
        }

        public static void GenerateClientData(Hotel hotel)
        {
            Console.WriteLine("Insert the client's first name");
            string inputClientFirstName = Console.ReadLine();
            Console.WriteLine("Insert the client's last name");
            string inputClientLastName = Console.ReadLine();
            Console.WriteLine("Insert the client's CNP ");
            string inputClientCNP = Console.ReadLine();
            Console.WriteLine("Insert the client's email adress");
            string inputClientEmail = Console.ReadLine();
            Console.WriteLine("Insert the client's number");
            string inputClientPhone = Console.ReadLine();
            
            hotel.RegisterClient(inputClientCNP, inputClientFirstName, inputClientLastName, inputClientEmail, inputClientPhone);
        }

        public static void RemoveTheClient(Hotel hotel)
        {
            Console.WriteLine("Insert the client  you want to remove ");
            string inputClientCNP = Console.ReadLine();
            hotel.RemoveClient(inputClientCNP);
        }

        public static void AddTheSingleRoom(Hotel hotel)
        {
            Console.WriteLine("Insert the number of the new room");
            int inputRoomNumber = Convert.ToInt32(Console.ReadLine());
            int inputRoomFloor = Convert.ToInt32(Console.ReadLine());
            hotel.AddSingleRoom(inputRoomNumber,inputRoomFloor);
        }

        public static void AddTheDoubleRoom(Hotel hotel)
        {
            Console.WriteLine("Insert the number of the new room");
            int inputRoomNumber = Convert.ToInt32(Console.ReadLine());
            int inputRoomFloor = Convert.ToInt32(Console.ReadLine());
            hotel.AddDoubleRoom(inputRoomNumber, inputRoomFloor);
        }

        public static void AddTheLuxuryRoom(Hotel hotel)
        {
            Console.WriteLine("Insert the number of the new room");
            int inputRoomNumber = Convert.ToInt32(Console.ReadLine());
            int inputRoomFloor = Convert.ToInt32(Console.ReadLine());
            hotel.AddLuxuryRoom(inputRoomNumber, inputRoomFloor);
        }

        public static void UpdateTheRoomPrice(Hotel Hotel)
        {
            Console.WriteLine("Insert the number of the room");
            int inputRoomNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the client's first name");
            double price = Convert.ToDouble(Console.ReadLine());
            Hotel.UpdteRoomPrice(inputRoomNumber, price);
        }

        public static void ShowAllTheRooms(Hotel hotel)
        {
            hotel.ShowAllRooms();
        }

        public static void AddABooking(Hotel hotel)
        {
            Console.WriteLine("Insert the client's CNP ");
            string inputClientCNP = Console.ReadLine();
            Console.WriteLine("Insert the number of the room");
            int inputRoomNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the check in date");
            DateTime inputCheckIn = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Insert the check out date");
            DateTime inputCheckOut = Convert.ToDateTime(Console.ReadLine());
            hotel.AddBooking(inputClientCNP,inputRoomNumber,inputCheckIn,inputCheckOut);
        }

        public static void ShowAllBookings(Hotel hotel)
        {
            hotel.AllBookings();
        }

        public static void ShowActiveBookings(Hotel hotel)
        {
            hotel.ActiveBooking();
        }

        public static void ClearBooking(Hotel hotel)
        {
            Console.WriteLine("Insert the client's CNP ");
            string inputClientCNP = Console.ReadLine();
            hotel.ClearBookingId(inputClientCNP);
        }
    }
}

