using System;

namespace OOPBasics
{
    class Program
    {
        //static string[] fNames = new string[0];
        //static string[] lNames = new string[0];
        //static string[] courses = new string[0];
        //static string[] grades = new string[0];

        static Grade[] grades = new Grade[0];
        static Book[] books = new Book[0];
        static void Main(string[] args)
        {

            //Grade grade = new Grade();
            //grade.firstName = "Tiandre";
            //grade.lastName = "Turner";
            //grade.courseNum = "NMAD180";
            //grade.grade = "A+";

            //Grade grade1 = new Grade();
            //grade.firstName = "Menna";
            //grade.lastName = "Nicola";
            //grade.courseNum = "NMAD180";
            //grade.grade = "A";
            //getRecord();
            //displayRecord(0);

            while(true)
            {
                getBookRecord();

                Console.Write("Do you want to continue? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }

            for (int index = 0; index < books.Length; index++)
                displayBookRecord(index);
        }

        public static void getRecord()
        {
            Console.Write("Enter first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string last = Console.ReadLine();
            Console.Write("Enter course name/num: ");
            string className = Console.ReadLine();
            Console.Write("Enter grade: ");
            string grade = Console.ReadLine();

            Grade currGrade = new Grade(first, last, className, grade);

            //currGrade.firstName = first;
            //currGrade.lastName = last;
            //currGrade.courseNum = className;
            //currGrade.grade = grade;

            int currentSize = grades.Length;
            int newsize = currentSize + 1;

            Array.Resize(ref grades, newsize);
            grades[currentSize] = currGrade;
        }

        public static void getBookRecord()
        {
           Console.Write("Enter the title of book: ");
            string title = Console.ReadLine();
            Console.Write("Enter the author: ");
            string author = Console.ReadLine();
            Console.Write("Enter the edition if applicable: ");
            int edition = int.Parse(Console.ReadLine());
            Console.Write("Enter the pages of the book: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("Enter the chapters of the book: ");
            int chapters = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of the book: ");
            double price = double.Parse(Console.ReadLine());

            Book book = new Book();
            book.title = title;
            book.author = author;
            book.edition = edition;
            book.pages = pages;
            book.chapters = chapters;
            book.price = price;

            //Book book = new Book();
            //book.title = "C# Book";
            //book.author = "R.B. Whitaker";
            //book.edition = 3;
            //book.pages = 100;
            //book.chapters = 30;
            //book.price = 23.55;

            //Book book1 = new Book();
            //book.title = "Lit Book";
            //book.author = "Random Author";
            //book.edition = 3;
            //book.pages = 10;
            //book.chapters = 30;
            //book.price = 5.99;



            int currentSize = books.Length;
            int newsize = currentSize + 1;

            Array.Resize(ref books, newsize);
            books[currentSize] = book;
        }

        public static void displayRecord(int index)
        {
            Console.WriteLine($"Name: {grades[index].firstName} {grades[index].lastName}\nCourse: {grades[index].courseNum}\nGrade: {grades[index].grade}");
        }


        public static void displayBookRecord(int index)
        {
            Console.WriteLine($"Author: {books[index].author}\nTitle: {books[index].title}");
        }
    }
}
