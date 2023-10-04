using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Programming_Assignment
{
    internal class Student
    {
        private static Random Generator = new Random();
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _studentNum;

        public Student (string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            _studentNum = Generator.Next(1000) + 555000;
            GenerateEmail();
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                this._firstName = value;
                GenerateEmail();

            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
                GenerateEmail();

            }
        }

        public int StudentNumber
        {
            get
            {
                return _studentNum;
            }
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

        public void ResetNum()
        {
            _studentNum = Generator.Next(1000) + 555000;
            GenerateEmail();
        }

        private void GenerateEmail()
        {
            _email = _firstName.Substring(0,3) + _lastName.Substring(0,3) + _studentNum.ToString().Substring(_studentNum.ToString().Length-3) + "@ICS4U.com";
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }
    }
}
