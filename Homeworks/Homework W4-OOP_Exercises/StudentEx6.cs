using System;
namespace Homework_W4_OOP_Exercises
{
	public class StudentEx6
	{
		public string name;
		public DateTime startDate;
		public DateTime endDate;
		public College college;
		public DateTime birthDate;
		public StudentEx6(string name,DateTime startDate,DateTime endDate,College college,DateTime birthDate)
		{
			this.name = name;
			this.startDate = startDate;
			this.endDate = endDate;
			this.college = college;
			this.birthDate = birthDate;
		}

		public bool IsStillStudent()
		{
			if (endDate<DateTime.Now)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public int GetAge()
		{
			
			return(  DateTime.Now.Year - birthDate.Year) ;
		}

		public void Print()
		{
            string show = $"Name is {name} , age {GetAge()} and his  college is :  {college.name}";
            Console.WriteLine(show);
            
		}
	}
}

