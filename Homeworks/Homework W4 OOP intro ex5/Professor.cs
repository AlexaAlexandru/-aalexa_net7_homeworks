using System;
namespace HomeWork_W4_OOP_intro
{
	public class Professor
	{
		public string name;
		public College college1;
		public string specialization;
		public List<string> studentsWhoGiveTheirDegree = new List<string>() ;
		public Student student;
		
		

		public Professor(string name, string specialization, College college1)
		{
			this.name = name;
			this.college1 = college1;
			this.specialization = specialization;
        }

		

		public void AddStudent()
		{
			studentsWhoGiveTheirDegree.Add(student.name);
			foreach (var item in studentsWhoGiveTheirDegree)
			{
				Console.WriteLine($"The students list contains the following students : {item}");
			}
		}


		

		public void Print()
		{
			Console.WriteLine($"The professor is {name}, from the University {college1.name} specialization {specialization}");

			foreach (string item in studentsWhoGiveTheirDegree)
			{
				Console.WriteLine($"The students for professor {name} are : {item}");
			}
		}

        public void Check()
        {

            if ( != college1.name)
            {
                throw new Exception("the professor's and student's college is not the same");
            }
        }

    }
}

