﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{

    
    class Book
    {
        Book book;
        List<int> pages = new List<int>();
        // TODO: Create properties
        // https://www.bookshare.org/cms/scanning-home/book-information-page

        private List<int> myVar;

        public List<int> MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        // Title
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // Author

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // ISBN

        private long isbn;

        public long ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        // Year

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }



    }
}
