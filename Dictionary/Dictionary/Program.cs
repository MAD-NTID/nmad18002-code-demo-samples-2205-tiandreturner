using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create a dictionary named books
            Dictionary<long, Book> books = new Dictionary<long, Book>();

            // LOAD books into the dictionary
            // The Hunger Games by Suzanne Collins
            books.Add(9780060935467, new Book() { ISBN = 9780060935467, Author = "Suzanne Collins", Title = "The Hunger Game", Year = 2009 });

            // The Chronicles of Narnia by C.S. Lewis
            books.Add(9780060935469, new Book() { ISBN = 9780060935469, Author = "C.S. Lewis", Title = "The Chronicles of Naria", Year = 2008 });

            // To Kill A Mockingbird by Harper Lee
            books.Add(9789571052052, new Book() { ISBN = 9789571052052, Author = "John Green", Title = "The Fault in Our Stars", Year = 2011 });

            // The Fault in Our Stars by John Green
            books.Add(9780385732321, new Book() { ISBN = 9780385732321, Author = "Matt De La Pena", Title = "Ball Don't Lie", Year = 2005 });

            // Ball Don't Lie by Matt De La Pena
            //books.Add(new Book() { Author = "Matt De La Pena", Title = "Ball Don't Lie" });

            // Add two more books to the list.            
            // The Secret Garden by Frances Burnett
            books.Add(9780064401883, new Book() { ISBN = 9780064401883, Author = "Frances Burnett", Title = "The Secret Garden", Year = 2014 });
            // My Sister's Keeper by Jodi Picoult
            //books.Add(new Book() { Title = "My Sister's Keeper", Author = "Jodi Picoult" });

            foreach (KeyValuePair<long, Book> book in books)
            {
                Console.WriteLine($"Key: {book.Key}\tValue: {book.Value}");
                Console.WriteLine($"Key: {book.Key}\tValue: {book.Value.ISBN}, {book.Value.Title} by {book.Value.Author}");
            }
        }
    }
}
