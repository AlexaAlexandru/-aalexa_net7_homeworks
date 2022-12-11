using System;
namespace Homework_W4_OOP_Exercises
{
	public class Book
	{
		public string title;
		public string author;
		public int year;

		public Book(string title,string author,int year)
		{
			this.title = title;
			this.author = author;
			this.year = year;

		}
		public string GetTitle()
		{
			return title;
		}
		public string GetAuthor()
		{
			return author;
		}
		public int GetYear()
		{
			return year;
		}
		public void SetTitle(string title)
		{
			this.title = title;
		}
		public void SetAuthor(string author)
		{
			this.author = author;
		}
		public void SetYear(int year)
		{
			this.year = year;
		}
	}
}

