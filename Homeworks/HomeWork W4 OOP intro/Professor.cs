using System;
namespace HomeWork_W4_OOP_intro
{
	public class Professor
	{
		public string name;
		public string faculty;
		public string specialization;
		public List<string> studentsWhoGiveTheirDegree = new List<string>() ;
		
		public Professor(string name, string faculty,string specialization)
		{
			this.name = name;
			this.faculty = faculty;
			this.specialization = specialization;
		}
		

		public Professor(string name, string faculty, string specialization, List<string> studentsWhoGiveTheirDegree)
		{
			this.name = name;
			this.faculty = faculty;
			this.specialization = specialization;
			this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
	
			studentsWhoGiveTheirDegree.Add("student1");
            studentsWhoGiveTheirDegree.Add("student2");
        }

		public void Print()
		{
			Console.WriteLine($"The professor is {name}, from the University {faculty} specialization {specialization}");

			foreach (string item in studentsWhoGiveTheirDegree)
			{
				Console.WriteLine($"The students for professor {name} are : {item}");
			}
		}

	}
}

