using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBasics
{
    class Grade
    {
        private string firstName;
        public string lastName;
        public string courseNum;
        public string grade;

        public Grade(string _firstName, string _lastName, string _courseNum, string _grade)
        {
            firstName = _firstName;
            lastName = _lastName;
            courseNum = _courseNum;
            grade = _grade;
        }
    }
}
