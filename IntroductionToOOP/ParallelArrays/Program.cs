using System;

namespace ParallelArrays
{
    class Program
    {
        static string[] fNames = new string[0];
        static string[] lNames = new string[0];
        static string[] courses = new string[0];
        static string[] grades = new string[0];
        //static string[,] multiDimensional = new string[4,4];
        static void Main(string[] args)
        {
            getRecord();
            displayRecord(0);
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

            int currentSize = fNames.Length;
            int newsize = currentSize + 1;

            Array.Resize(ref fNames, newsize);
            Array.Resize(ref lNames, newsize);
            Array.Resize(ref courses, newsize);
            Array.Resize(ref grades, newsize);


            fNames[currentSize] = first;
            lNames[currentSize] = last;
            courses[currentSize] = className;
            grades[currentSize] = grade;
        }

        public static void displayRecord(int index)
        {
            Console.WriteLine($"Name: {fNames[index]} {lNames[index]}\nCourse: {courses[index]}\nGrade: {grades[index]}");
        }
    }
}
