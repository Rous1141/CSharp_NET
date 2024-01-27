
using System;
namespace StudentV1.Entities
{
	/// <summary>
	/// Student class for OOP mindset
	/// </summary>
	internal class Student
	{ //Class is a mold/blueprint containning many placeholder variables that describe this class
	  //To clone an object from this mold, we need to contruct from the mold

		private string _id; //placeholder vars
		private string _name; //convention -> camelCase
		private string _email; // _variableName => contain '_' ot help difference the Constructor local variables, avoid this.var
		private int _birthYear;
		private double _gpa;
        // private variable to secure the data type
        // only when you Get() to see that data
        // public will by default show you to data type

        public Student(string id, string name, string email, int birthYear, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _birthYear = birthYear;
            _gpa = gpa;
        }

        //Create a mold to create the right object to pour in the right data
        //Mold use that data to contruct an object
        //This process use a special method
        //That method is Contructor!
        // quick command Contrusctor

        public string GetName() => _name;

        public int GetBirthYear() => _birthYear;

        public string GetEmail() => _email;

        public double GetGPA() => _gpa;
       //Expression Body

        //Method to show ALL datas at once! -> ToString()

        //Traditional method
        public void ShowProfile()
        {
            Console.WriteLine(@$"Here are my infomations:
Id: {_id}
Name: {_name}
Email: {_email}
GPA Score: {_gpa}
Birth Year: {_birthYear}"+"\n\n");
        }

    }
}

