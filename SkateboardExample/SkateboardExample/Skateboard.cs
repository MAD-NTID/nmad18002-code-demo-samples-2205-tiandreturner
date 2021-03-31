using System;
using System.Collections.Generic;
using System.Text;

namespace SkateboardExample
{
    class Skateboard
    {
        private int numOfWheels;

        public int NumOfWheels 
        {
            get { return numOfWheels;  }
            set { numOfWheels = value;  }
        }

        private string typeOfBoard;
        public string TypeOfBoard
        {
            get { return typeOfBoard; }
            set { typeOfBoard = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // default constructor
        public Skateboard()
        {
            NumOfWheels = 4;
            TypeOfBoard = "Skateboard";
            Color = "Black";
        }

        public Skateboard(int _numOfWheels, string _typeOfBoard, string _color)
        {
            NumOfWheels = _numOfWheels;
            TypeOfBoard = _typeOfBoard;
            Color = _color;
        }

        public void Skate()
        {
            Console.WriteLine("Skrt!!");
        }

        public override string ToString()
        {
           return  String.Format($"Number of Wheels: {NumOfWheels}\nTypeOfBoard: {TypeOfBoard}\nColor: {Color}");
        }
    }
}
