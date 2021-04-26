using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Book
    {
        // TODO: Create properties
        // https://www.bookshare.org/cms/scanning-home/book-information-page

        public Book()
        {
            Title = "N/A";
        }

        public Book(string _title, string _author)
        {

        }

        // Title
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }


    }
}
