namespace Homework_W5_OOP_advanced.Exercise7
{
    public class LuxuryRoom: Room
    {
        public string View { get; set; }

        public LuxuryRoom(int number, int floor): base(number, floor)
		{
            View = "Mountain view with paradise pool";
            BedRooms = 3;
			Price = 150;
		}
    }
}

