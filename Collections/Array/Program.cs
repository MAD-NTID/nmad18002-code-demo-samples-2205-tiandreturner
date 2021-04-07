using System;

namespace Arrays
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // create an array of 5 Books
            Book[] books = new Book[5];

            // add the informations of 5 books
            // The Hunger Games by Suzanne Collins
            Book book = new Book();
            book.Author = "Suzanne Collins";
            book.Title = "The Hunger Game";

            books[0] = book;

            // The Chronicles of Narnia by C.S. Lewis
            books[1] = new Book() { Author = "C.S. Lewis", Title = "The Chronicles of Naria" };

            // To Kill A Mockingbird by Harper Lee
            books[2] = new Book() {  Title = "To Kill A Mockingbird", Author = "Harper Lee", };

            // The Fault in Our Stars by John Green
            books[3] = new Book() { Author = "John Green", Title = "The Fault in Our Stars" };

            // Ball Don't Lie by Matt De La Pena
            books[4] = new Book() { Author = "Matt De La Pena", Title = "Ball Don't Lie" };

            // "expand" to two more book and add it to the array.
            Array.Resize(ref books, books.Length + 2);

            // The Secret Garden by Frances Burnett
            books[5] = new Book() { Author = "Frances Burnett", Title = "The Secret Garden" };
            // My Sister's Keeper by Jodi Picoult
            books[6] = new Book() {  Title = "My Sister's Keeper", Author = "Jodi Picoult" };

            // Display all of the books
            for ( int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{books[i].Title} by {books[i].Author}" );
            }
        }
    }
}
