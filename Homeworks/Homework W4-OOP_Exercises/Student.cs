using System;
namespace Homework_W4_OOP_Exercises
{
	public class Student
	{
		public string firstName;
		public string lastName;
		public int studentId;
		public double gpa;
      
        public Student(string firstName,string lastName,int studentId,double gpa)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.studentId = studentId;
			this.gpa = gpa;
		}

		public string GetFullName()
		{
			string text=$"{firstName} {lastName}";
			return text;
		}

		public bool HasHonors()
		{
			Console.WriteLine("Does the student has honors ? ");
			if (gpa>=3.5)
			{
                return true;
            }
			else
			{
				return false;
			}
		}

		
		

	}
}

