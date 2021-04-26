using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsInObjects
{
    class Course
    {
        public string CourseID { get; set; }
        public string Name { get; set; }

        public int Credits { get; set; }

        public string Room { get; set; }

        public string Instructor { get; set; }

        public Course(string _courseID, string _courseName, int _credits, string _room, string _instructor)
        {
            CourseID = _courseID;
            Name = _courseName;
            Credits = _credits;
            Room = _room;
            Instructor = _instructor;
        }

        public override string ToString()
        {
            return $"{CourseID}: {Name}\nInstructor: {Instructor}\nCredits: {Credits}\nRoom: {Room}";
        }

    }
}
