using System;

namespace BuildingOnOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = new Course[3];
            Course course = new Course();
            courses[0] = course;
            Console.WriteLine(course.CourseName);

            Course course1 = new Course("180", "NMAD");
            course1.CourseStudents = 4;

            //Console.WriteLine(course1.CourseName);
            course1.Credits = -25;
            courses[1] = course1;
            //Console.WriteLine(course1.ToString());
            //Console.WriteLine($"Credit: {course1.Credits}");
            //Console.WriteLine($"Total students: {course1.TotalStudents}");
            Course course2 = new Course("200", "NACT", "Thomas Simpson", 7);

            //Console.WriteLine(course2.CourseName);
            course2.Credits = 4;
            //Console.WriteLine($"Credit: {course2.Credits}");
            courses[2] = course2;
            //course2.Credits = 26;
            //Console.WriteLine($"Credit: {course2.Credits}");

            //Console.WriteLine($"Total students: {course2.TotalStudents}");

            //Console.WriteLine(course2.ToString());

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i].ToString());
            }

            // does the same thing as the first loop.
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }



        }
    }
}
