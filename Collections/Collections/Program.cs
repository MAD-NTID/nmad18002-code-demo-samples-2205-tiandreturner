using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an empty list of Book
            List<Book> books = new List<Book>();
            //List<int> numbers = new List<int>();

            // add the informations of 5 books
            // The Hunger Games by Suzanne Collins
            Book book = new Book();
            book.Author = "Suzanne Collins";
            book.Title = "The Hunger Game";

            books.Add(book);

            // The Chronicles of Narnia by C.S. Lewis
            books.Add(new Book() { Author = "C.S. Lewis", Title = "The Chronicles of Naria" });

            // To Kill A Mockingbird by Harper Lee
            books.Add( new Book() { Title = "To Kill A Mockingbird", Author = "Harper Lee", });

            // The Fault in Our Stars by John Green
            books.Add(new Book() { Author = "John Green", Title = "The Fault in Our Stars" });

            // Ball Don't Lie by Matt De La Pena
            books.Add(new Book() { Author = "Matt De La Pena", Title = "Ball Don't Lie" });


            // Add two more books to the list.            
            // The Secret Garden by Frances Burnett
            books.Add(new Book() { Author = "Frances Burnett", Title = "The Secret Garden" });
            // My Sister's Keeper by Jodi Picoult
            books.Add(new Book() { Title = "My Sister's Keeper", Author = "Jodi Picoult" });


            // Display all of the books using for loop
            //for (int i = 0; i < books.Count; i++)
            //{
            //    Console.WriteLine($"{books[i].Title} by {books[i].Author}");
            //}

            // Display all of the books using foreach loop
            foreach(Book currentBook in books)
            {
                Console.WriteLine($"{currentBook.Title} by {currentBook.Author}");
            }
        }
    }
}
