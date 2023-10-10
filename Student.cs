using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Programming_Assignment
{
    class Student: IComparable<Student>
    {
        private static Random Generator = new Random();
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _studentNum;

        public Student (string firstName, string lastName)
        {
            this._firstName = firstName.Trim();
            this._lastName = lastName.Trim();
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
            if (_firstName.Length >= 3 && _lastName.Length >= 3)
            {
                _email = _firstName.Substring(0, 3) + _lastName.Substring(0, 3) + _studentNum.ToString().Substring(_studentNum.ToString().Length - 3) + "@ICS4U.com";
            }
            else if (_firstName.Length >= 3)
            {
                _email = _firstName.Substring(0, 3) + _lastName + _studentNum.ToString().Substring(_studentNum.ToString().Length - 3) + "@ICS4U.com";
            }
            else if (_lastName.Length >= 3)
            {
                _email = _firstName + _lastName.Substring(0, 3) + _studentNum.ToString().Substring(_studentNum.ToString().Length - 3) + "@ICS4U.com";
            }
            else
            {
                _email = _firstName + _lastName + _studentNum.ToString().Substring(_studentNum.ToString().Length - 3) + "@ICS4U.com";
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }

        public int CompareTo(Student that)
        {
            if (this.LastName.CompareTo(that.LastName) == 0) 
                return this.FirstName.CompareTo(that.FirstName);
            return this.LastName.CompareTo(that.LastName);  
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
                return false;
            return this.FirstName == student.FirstName && this.LastName == student.LastName && this.StudentNumber == student.StudentNumber;
        }
        
        public override int GetHashCode()
        {
            return (_firstName + _lastName + _studentNum).GetHashCode();
        }
    }
}
