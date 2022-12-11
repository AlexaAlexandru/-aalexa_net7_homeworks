using System;
namespace HomeWork_W4_OOP_intro
{
	public class Student
	{
		public string name;
		public DateTime startDate;
		public DateTime endDate;
		public College college;
		public DateTime birthDate;

		public Student(string name, DateTime startDate, DateTime endDate, DateTime birthDate, College college)
		{
			this.name = name;
			this.startDate = startDate;
			this.endDate = endDate;
			this.college = college;
			this.birthDate = birthDate;

		}

		public bool IsStillStudent()
		{
			Console.WriteLine("Is the person still a student ? ");
			if (endDate< DateTime.Now)
			{
				return true;

			}
			else
			{
				return false;

            }

			
		}

		public int GetAge()
		{
			Console.WriteLine("Age ");
			return DateTime.Now.Year - this.birthDate.Year;

        }

        public void Print()
        {
            string show = $"Name is {name} , age {GetAge()} and his  college is :  {college.name}";
            Console.WriteLine(show);
        }
    }
}

