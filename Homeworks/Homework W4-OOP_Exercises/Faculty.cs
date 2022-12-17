using System;
namespace Homework_W4_OOP_Exercises
{
	public class Faculty
	{
        public string firstName;
        public string lastName;
        public int employeeId;
		public List<string> list = new List<string>() { };
        public Faculty(string firstName,string lastName,int employeeId,List<string>list)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.employeeId = employeeId;
			this.list = list;
			
            

        }
		public string GetFullName()
		{
			string output = $"{this.firstName}{this.lastName}";
			return output;
		}

		


	


	}
}

