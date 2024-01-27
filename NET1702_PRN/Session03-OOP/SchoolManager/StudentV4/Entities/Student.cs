using System;
namespace StudentV4.Entities
{
    public class Student
    {
        private string _name;
        private string _id;
        private int _age;
        private int _yob;
        private string _email;
        private double _gpa;

        public Student(string name, string id, int age, int yob, string email, double gpa)
        {
            _name = name;
            _id = id;
            _age = age;
            _yob = yob;
            _email = email;
            _gpa = gpa;
        }

        public string GetName() => _name;
        public string GetEmail() => _email;

        public void SetName(string name) => _name = name;
        public void SetEmail(string email) => _email = email;

        //They are both methods to use actions on name.
        //C# got a quicker method to blend both method Set Get into one method

        public int Yob
        {
            get { return _yob; }
            set { _yob = value; } // 'value' is a new key for the value of method to update the value
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public string name
        {
            get =>  _name;         //Using expression body
            set => _name = value; 
        }

    }
}

