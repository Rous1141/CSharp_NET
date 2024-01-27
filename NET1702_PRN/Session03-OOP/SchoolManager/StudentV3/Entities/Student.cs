using System;
namespace StudentV3.Entities
{
	public class Student
	{
        private string _name;
        private string _id;
        private int _age;
        private int _yob;
        private string _email;
        private double _gpa;

        //Multi-constrcutor
        public Student(string name, string id, int age, int yob, string email, double gpa)
        {
            _name = name;
            _id = id;
            _age = age;
            _yob = yob;
            _email = email;
            _gpa = gpa;
            //Full constructor
        }

        public Student(string name, string id)
        {
            _name = name;
            _id = id;
            //Partial contructor
        }

        //quickly generate a Constructor ctor _tab
        public Student()
        {
            //Default Consructor
        }

        //The amount of constructor is the amount of method you can create the Object
        //If class already has Contructor, the default will not be created by the compiler
        //You will have to create the default Constructor
        //Must be explicit when create the constructor
        //By logic, a class must always have a default constructor
    }
}

