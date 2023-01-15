using System;
namespace Homework_W5_OOP_advanced.Exercise4
{
	public abstract class Employee
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public double Salary { get; set; }
		private string _contactInfo;
		public string Email { get; set; }
        public int Phone { get; set; }

		public abstract double CalculateBonus();

		public virtual string GetContactInfo()
		{
			return _contactInfo;
		}

		public virtual string GetEmail()
		{
			return Email;
		}
		
	}
}

