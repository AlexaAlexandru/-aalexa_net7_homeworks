using System;


namespace Homework_W4_OOP_Exercises
{
	public class Professor
	{
		public string name;
		public College college;
		public string specialization;
		public StudentEx6 student;
        public string collegeStudent;

        public List<StudentEx6> studentsWhoGiveTheirDegree = new List<StudentEx6>() { };

        public Professor(string name, College college,string specialization)
		{
			this.name = name;
			this.college = college;
            this.specialization = specialization;
            
            
        }

		public Professor(string name, College college, string specialization, List<StudentEx6>studentsWhoGiveTheirDegree)
		{
			this.name = name;
            this.college = college;
            this.specialization = specialization;
			this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;

            if (college.name.ToLower() != this.college.name.ToLower())
            {
                throw new Exception("Warning! The professor and the student don't have the same college");
            }
            else
            {
                Console.WriteLine("The professor and the student match the college they declared");
            }
        }

        public void AddStudent(StudentEx6 item)
        {
            studentsWhoGiveTheirDegree.Add(item);
        }

        public void Print()
        {

            Console.WriteLine($"The professor {this.name} teaches at {this.college.name} ");
        }

    }

}

