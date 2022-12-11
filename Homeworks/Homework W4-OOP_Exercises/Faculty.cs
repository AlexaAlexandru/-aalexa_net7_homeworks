using System;
namespace Homework_W4_OOP_Exercises
{
	public class Faculty
	{
        public string firstName;
        public string lastName;
        public int employeeId;
		public List<string> subjectsTaught=new List<string>();
        public Faculty(string firstname,string lastName,int employeeId,List<string> subjectsTaught)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.employeeId = employeeId;
			this.subjectsTaught = subjectsTaught;

		}
		public string GetFullName()
		{
			string output = $"{this.firstName}{this.lastName}";
			return output;
		}

		/*
		public var GetSubjectsTaught()
		{
			subjectsTaught.Add(subjectsTaught);

			return listSubject;
			 
		}
		*/


	}
}

