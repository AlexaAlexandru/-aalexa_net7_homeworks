using System;
namespace Homework_W5_OOP_advanced.Exercise7
{
    public class SingleRoom: Room
    {
        public string View { get; set; }

		public SingleRoom(int number, int floor): base(number, floor)
        {
            View= "City view";
            BedRooms = 1;
			Price = 50;
		}
    }
}

