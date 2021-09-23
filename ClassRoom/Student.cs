using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        public string Name { get; set; }

        //public int FødselsMåned { get; set; }

        private int _birthMonth;

        public int BirthMonth
        {
            get { return _birthMonth; }
            set {
                if (value >= 1 && value <= 12)
                  _birthMonth = value;
                else
                  throw new ArgumentException($"The value should be between 1-12, you wrote {value}");
            }
        }

        public int BirthDay { get; set; }

        public Student(string name, int month, int day)
        {
            Name = name;
            BirthMonth = month;
            BirthDay = day;
        }

        public string Season()
        {
            switch (BirthMonth)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return $"This month: {BirthMonth} are not in the interval: 1-12";

            }

        }

        public override string ToString()
        {
            return $"Name: {Name} , Month: {BirthMonth}, day: {BirthDay}, Season: {Season()}";
        }


    }
}
