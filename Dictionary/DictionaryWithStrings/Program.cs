using System;
using System.Collections.Generic;

namespace DictionaryWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary and named it students
            Dictionary<int, string> students = new Dictionary<int, string>();

            // load each student's name with a fake id into the dictionary
            // 110 -- Menna
            students.Add(110, "Menna");

            // 111 -- Alvin
            students.Add(111, "Alvin");

            // 112 -- Sahand
            students.Add(112, "Sahand");
            // 113 -- Yunhao
            students.Add(113, "Yunhao");

            //while (true)
            //{

            //    foreach(KeyValuePair<int,string> student in students)
            //        Console.WriteLine($"{student.Key} -- {student.Value}");

            //    Console.Write("Enter your id to replace: ");
            //    int id = int.Parse(Console.ReadLine());

            //    Console.Write("Enter your name: ");
            //    string studentName = Console.ReadLine();

            //    students[id] = studentName;

            //    //if (!students.ContainsKey(id))
            //    //    students.Add(id, studentName);
            //    //else
            //    //{
            //    //    Console.WriteLine($"This id {id} is already exist");
            //    //    continue;
            //    //}

            //    //Console.Write("Do you want to add a new student? (y/n): ");
            //    //if (Console.ReadLine().ToLower() == "y")
            //    //    break;
            //}

            // list the students
            foreach (KeyValuePair<int,string> keyValues in students)
            {
                Console.WriteLine($"Key: {keyValues.Key}\tValue: {keyValues.Value}");
            }


            // replace the student with another student??
            students[111] = "Tiandre";

            Console.WriteLine("After replacing Alvin with Tiandre");
            foreach (KeyValuePair<int, string> keyValues in students)
            {
                Console.WriteLine($"Key: {keyValues.Key}\tValue: {keyValues.Value}");
            }

            Console.WriteLine($"{students.Count} elements in students");

            // remove a student from the list
            students.Remove(112);
            Console.WriteLine("After removing Sahand");
            foreach (KeyValuePair<int, string> keyValues in students)
            {
                Console.WriteLine($"Key: {keyValues.Key}\tValue: {keyValues.Value}");
            }


        }
    }
}
