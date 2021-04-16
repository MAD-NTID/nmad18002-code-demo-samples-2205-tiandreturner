using System;
using System.Collections.Generic;

namespace StudentRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class> classes = new List<Class>();
            List<Student> students = new List<Student>();
           while(true)
            {
                Console.Write("Enter the course name: ");
                string courseName = Console.ReadLine();

                Console.Write("Enter the course number: ");
                int courseNum = int.Parse(Console.ReadLine());

                while(true)
                {
                    Console.Write("Enter the student's name: ");
                    string studentName = Console.ReadLine();

                    Console.Write("Enter the student's major: ");
                    string major = Console.ReadLine();

                    Console.Write("Enter the student's year level: ");
                    string yearLevel = Console.ReadLine();

                    Student student = new Student() { Name = studentName, Major = major, Year = yearLevel };

                    students.Add(student);

                    Console.Write("Do you want to add a new student? (y/n): ");
                    if (Console.ReadLine().ToLower() != "y")
                        break;
                }

                //Class current = new Class() { CourseName = courseName, CourseNumber = courseNum }
                classes.Add(new Class() { CourseName = courseName, CourseNumber = courseNum })

            }
        }
    }
}
