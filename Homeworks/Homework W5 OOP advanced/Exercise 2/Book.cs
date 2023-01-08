using System;
namespace Homework_W5_OOP_advanced.Exercise2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private int PageCount
        {

            get { return this.pageCount; }
            set { this.pageCount = value; }

        }
        public int pageCount;

        public int CurrentPage { get; private set; }

        public Book(string title, string author, int pageCount)
        {
            this.Title = title;
            this.Author = author;
            this.pageCount = pageCount;
            CurrentPage = 1;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public int GetPageCount()
        {
            return PageCount;
        }
        public int GetCurrentPage()
        {
            return CurrentPage;
        }
        public int NextPage()
        {
            return CurrentPage++;
        }
        public int PreviousPage()
        {
            return CurrentPage--;
        }

    }
}
