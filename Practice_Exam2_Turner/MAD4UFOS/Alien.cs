using System;
using System.Collections.Generic;
using System.Text;

namespace MAD4UFOS
{
    /**
     * MUST HAVE COMMENTS OTHERWISE YOU LOSE POINTS!
     *
     */
    class Alien
    {
        const char DATE_BACKSLASH = '/';
        const char DATE_DASH = '-';
        private DateTime date;

        private DateTime Date
        {
            get;
            set;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                if(value.Length == 0)
                {
                    name = "Unidentifed";
                }
                else
                    name = value; 
            }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set 
            {
                if (value.Length == 0)
                {
                    location = "N/A";
                }
                else
                    location = value;
            }
        }

        //private string date;
        //public string Date 
        //{ 
        //    get
        //    {
        //        return date;
        //    }
        //    set
        //    {
        //        if(value.Length == 0 || !ValidDate(value))
        //        {
        //            date = "03/31/2021";
        //        }
        //        else
        //        {
        //            date = value;
        //        }
        //    }
        //}

        // default constructor
        public Alien()
        {
            Name = "Unidentified";
            Date= DateTime.Now; //Date = "03/31/2021"
            Location = "N/A";

        }

        // 3-parameterized constructor
        public Alien(string _name, DateTime _date, string _location)
        {
            Name = _name;
            Date = _date;
            Location = _location;
        }

        public static bool ValidDate(string date)
        {
            string[] dateInfo = date.Split(new char[] { DATE_BACKSLASH, DATE_DASH });
            int year = 0;
            if(!CheckMonth(dateInfo[0]) || !CheckYear(dateInfo[2], out year) || !CheckDay(dateInfo[1], year) )
            {
                return false;
            }

            return true;
        }

        private static bool CheckMonth(string month)
        {
            if (month.Length > 2)
            {
                return false;
            }

            if(!((int.TryParse(month, out int monthNumber)) && (monthNumber >= 1 && monthNumber <= 12)) )
            {
                return false;
            }

            return true;
        }

        private static bool CheckDay(string day, int year) 
        {
            int dayNumber = 0;
            if (day.Length > 2)
            {
                return false;
            }

            if (!((int.TryParse(day, out dayNumber)) && (dayNumber >= 1 && dayNumber <= 31)))
            {
                return false;
            }

            if(!(year % 4 == 0 && (dayNumber >= 1 && dayNumber <= 29)))
            {
                return false;
            }


            return true;
        }

        private static bool CheckYear(string year, out int yearDigit)
        {
            yearDigit = 0;
            if(year.Length != 4)
            {
                return false;
            }

            return int.TryParse(year, out yearDigit);
        }


        public override string ToString()
        {
            return $"Name: {Name}\nDate: {Date}\nLocation: {Location}";
        }
    }
}
