using System;
using System.Collections.Generic;

namespace ListMethods
{
    class Program
    {
        static List<Book> books = new List<Book>()
        {
            new Book() { ISBN = 9780060935467, Author = "Suzanne Collins", Title = "The Hunger Game", Year = 2009 },
            new Book() { ISBN = 9780060935467, Author = "C.S. Lewis", Title = "The Chronicles of Naria", Year = 2008 },
            new Book() { ISBN = 9789571052052, Author = "John Green", Title = "The Fault in Our Stars", Year = 2011 },
            new Book() { ISBN = 9780385732321, Author = "Matt De La Pena", Title = "Ball Don't Lie", Year = 2005 },
            new Book() { ISBN = 9780064401883, Author = "Frances Burnett", Title = "The Secret Garden", Year = 2014 }
        };

        static void Main(string[] args)
        {
            ShowBooks();
            // Insert My Sister's Keeper by Jodi Picoult at the fourth element
            books.Insert(3,new Book() { ISBN = 9781741143478, Title = "My Sister's Keeper", Author = "Jodi Picoult" });

            //Console.WriteLine("\nAfter inserting");
            //ShowBooks();

            //Console.WriteLine("After replacing the first element" );
            //books[0] = new Book() { Title = "The Help", Author = "Kathryn Stockett", ISBN = 9780241146200 };
            
            // Comparing the books by year
            //books.Sort(YearComparer);
            //Console.WriteLine("\n\nAfter sorting by year");
            //ShowBooks();

            // comparing the books by ISBN
            books.Sort(ISBNComparer);
            Console.WriteLine("\n\nAfter sorting by ISBN");
            ShowBooks();

            //Console.WriteLine("\nAfter Removing");
            // remove The Fault in Our Stars by John Green from the list
            //books.RemoveAt(2);

            //ShowBooks();

            //Console.WriteLine($"{books.Count} books in the list");
            // How to remove all elements from the list?
            //books.Clear();
            //books.RemoveAt(books.Count-1);
            // OR

            //for (int i = 0; i < books.Count; i++)
            //{
            //    books.RemoveAt(i);
            //}
            //ShowBooks();
            //Console.WriteLine($"{books.Count} books in the list");
        }

        public static int YearComparer(Book book, Book secondBook)
        {
            return book.Year.CompareTo(secondBook.Year);
        }

        public static int ISBNComparer(Book book, Book secondBook)
        {
            return book.ISBN.CompareTo(secondBook.ISBN);
        }

        public static void ShowBooks()
        {
            //for (int i = 0; i < books.Count; i++)
            //{
            //    Console.WriteLine($"{i}. {books[i].Title} by {books[i].Author}");
            //}
            // Display all of the books
            foreach (Book currentBook in books)
            {
                Console.WriteLine($"========= ISBN #{currentBook.ISBN} =========\n{currentBook.Title} by {currentBook.Author}");
            }
        }
    }
}
