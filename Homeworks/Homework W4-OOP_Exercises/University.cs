using System;
namespace Homework_W4_OOP_Exercises
{
	public class University
	{
        public string name;
        public List<Student> students;
        public List<Faculty> faculties;

        public University(string name)
        {
            this.name = name;
            students = new List<Student>();
            faculties = new List<Faculty>();
        }

        public void AddStudent(Student item)
        {
            students.Add(item);
        }

        public int GetStudentCount()
        {
            return students.Count();
        }

        public void AddFaculties(Faculty item)
        {
            faculties.Add(item);
        }

        public int GetFacultiesCount()
        {
            return faculties.Count();
        }

        
    }
}

