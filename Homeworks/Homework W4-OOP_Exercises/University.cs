using System;
namespace Homework_W4_OOP_Exercises
{
	public class University
	{
		public string name;
		public Student student;
		public Faculty faculty;
        List<string> listStudents = new List<string>();
        public University(string name)
		{
			this.name = name;
			this.student = student;
			this.faculty = faculty;
		}

        public List<string> AddStudent(Student john)
		{

            listStudents.Add(student.GetFullName());

			return listStudents;
		}
		/*
        public void AddFaculty()
		{
			faculty.GetSubjectsTaught();
		}
		*/
		public int GetStudentCount()
		{ 
			return listStudents.Count();
		}
	}
}

