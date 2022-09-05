using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ;set; }
        public string Author { get ;set; }
        public string Code { get ;set;  }
        


        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

     
    }
}
