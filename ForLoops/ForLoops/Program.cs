using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];

            //Console.WriteLine("Enter student 1's name: ");
            //students[0] = Console.ReadLine();

            //Console.WriteLine("Enter student 2's name: ");
            //students[1] = Console.ReadLine();

            //Console.WriteLine("Enter student 3's name: ");
            //students[2] = Console.ReadLine();

            //Console.WriteLine("Enter student 4's name: ");
            //students[3] = Console.ReadLine();

            //Console.WriteLine("Enter student 5's name: ");
            //students[4] = Console.ReadLine();


            //Console.WriteLine("----------List of all students----------\n");
            //Console.WriteLine(students[0]);
            //Console.WriteLine(students[1]);
            //Console.WriteLine(students[2]);
            //Console.WriteLine(students[3]);
            //Console.WriteLine(students[4]);

            for (int index = 0; index < students.Length; index++)
            {
                //index = 1;
                Console.WriteLine($"Enter student {index + 1}'s name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"{name} goes in the position of {index} in the array");
                students[0] = name;
                students[index] = name;
            }

            //Console.WriteLine("----------List of all students----------\n");
            //for (int newindex = 0; newindex < students.Length; newindex++)
            //{
            //    Console.WriteLine(students[newindex]);
            //}

            Console.WriteLine("----------List of all students IN ABC ORDER----------\n");

            Array.Sort(students);
            for (int index = 0; index < students.Length; index++)
            {
                Console.WriteLine(students[index]);
            }

            Console.WriteLine("Current number of students in this class: " + students.Length);
            Console.WriteLine("How many students do you want to add to this class: ");
            int numToAdd = int.Parse(Console.ReadLine());

            Array.Resize(ref students, students.Length + numToAdd);
            Console.WriteLine("Current number of students in this class: " + students.Length);


            //int start;
            //Console.Write("Enter the number to start: ");
            //int end = int.Parse(Console.ReadLine());
            //for (start = 1; start <= 9; start++)
            //{
            //    Console.WriteLine(start);
            //}

            //Console.WriteLine(index);


            //int index;

            //if(index <= 10)
            //{

            //}


            //index = index + 2
            //for (index =0; index <= 10; index++ )
            //{
            //    Console.WriteLine(index);
            //}

            //const int MAX = 10;
            //for (int newIndex = 0; newIndex <= 10; newIndex++)
            //{
            //    Console.WriteLine(newIndex);
            //    //newIndex = 4;

            //}


            //Console.WriteLine(index);
        }
    }
}
