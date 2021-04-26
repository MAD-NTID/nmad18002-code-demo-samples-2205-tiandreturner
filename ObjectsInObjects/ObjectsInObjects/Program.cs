using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectsInObjects
{
    class Program
    {
        const string FILE_NAME = @"C:\Users\tjtics\source\repos\nmad18002-code-demo-samples-2205-tiandreturner\ObjectsInObjects\students.json";
        static List<Student> students;
        static void Main(string[] args)
        {

            LoadData();

            while (true)
            {
                DisplayMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        Student student = CreateStudent();
                        students.Add(student);
                        break;
                    case "2":
                        DisplayStudents();
                        break;
                    case "3":
                        DisplayStudentCourses();
                        break;
                    case "4":
                        ExitProgram();
                        break;
                }
            }
        }

        private static void SaveData()
        {
            string studentStr = JsonConvert.SerializeObject(students);
            StreamWriter streamWriter = new StreamWriter(FILE_NAME);
            streamWriter.WriteLine(studentStr);
            streamWriter.Close();
            Console.WriteLine("Saved the data to a file");
        }

        private static void LoadData()
        {
            if (File.Exists(FILE_NAME))
            {
                StreamReader streamReader = new StreamReader(FILE_NAME);
                string studentStr = streamReader.ReadToEnd();
                students = JsonConvert.DeserializeObject<List<Student>>(studentStr);
                streamReader.Close();
            }
            else
              students = new List<Student>();
        }

        private static void DisplayStudentCourses()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FullName}");
            }
            Console.Write("Enter the full name of the student to see their courses: ");
            string nameOfStudent = Console.ReadLine();

            foreach(Student student in students)
            {
                if(nameOfStudent == student.FullName)
                {
                    Console.WriteLine(student.GetCourses());
                }
            }
        }

        private static void ExitProgram()
        {
            Console.Write("Are you sure that you want to exit? (Y/N): ");

            if (Console.ReadLine().ToUpper()[0] == 'Y')
            {
                SaveData();
                Console.WriteLine("Exiting the program...");
                Environment.Exit(0);
            }
        }

        private static void DisplayStudents()
        {
          foreach(Student student in students)
          {
             Console.WriteLine(student);
                //Console.WriteLine(student.ToString());
          }
        }

        private static Student CreateStudent()
        {
            List<Course> studentCourses = new List<Course>();

            Console.Write("Enter the student's first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the student's last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the student's age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter the student year's level: ");
            string yearLevel = Console.ReadLine();

            do
            {
                Course course = CreateCourse();
                studentCourses.Add(course);

                Console.Write("Do you want to add another course? (Y/N): ");
            } while (Console.ReadLine().ToUpper()[0] == 'Y');
            

            Student student = new Student(firstName, lastName, age, yearLevel, studentCourses);
            return student;
        }

        private static Course CreateCourse()
        {
            Console.Write("Enter the course id: ");
            string id = Console.ReadLine();

            Console.Write("Enter the course name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the instructor for this course: ");
            string instructor = Console.ReadLine();

            Console.Write("Enter the credits for this course: ");
            int credits = int.Parse(Console.ReadLine());

            Console.Write("Enter the room number for this course: ");
            string roomLoc = Console.ReadLine();

            Course course = new Course(id, name, credits, roomLoc, instructor);

            return course;

        }

        private static void DisplayMenu()
        {
            Console.Write("1. Enter New Student\n2. Display All Students\n3. Display a Student's courses\n4. Exit\n\nSelect one of the options: ");
        }
    }
}
