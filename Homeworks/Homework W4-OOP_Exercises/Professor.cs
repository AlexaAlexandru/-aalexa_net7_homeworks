using System;
namespace Homework_W4_OOP_Exercises
{
	public class Professor
	{
		public string name;
		public College college1;
		public string specialization;
		public StudentEx6 student;
        
        public List<StudentEx6> studentsWhoGiveTheirDegree = new List<StudentEx6>() { };
        public Professor(string name, College college,string specialization)
		{
			this.name = name;
			this.college1 = college;
			this.specialization = specialization;
		}
		public Professor(string name, College college, string specialization, List<StudentEx6>studentsWhoGiveTheirDegree)
		{
			this.name = name;
            this.college1 = college;
            this.specialization = specialization;
			this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
      
        }


        
        public void Validation()
        {
            string studentCollege = student.college.name;
            
            if (college1.name == studentCollege)
            {
                Console.WriteLine($"{this.name} and {student.name} have the same college");
            }
            else
            {
                throw new Exception("Warning! The professor and the student don't have the same college");
            }
        }
        public void AddStudent(StudentEx6 item)
        {
            studentsWhoGiveTheirDegree.Add(item);
        }

        public void Print()
        {
            Console.WriteLine($"The professor {this.name} teaches at {college1.name}");
            Console.WriteLine($"The student {student.name} ");
        }

        
    }
}

