using System;
namespace StudentV2.Entities
{
	public class Student
	{
		private string _name;
        private string _id;
        private int _age;
        private int _yob;
        private string _email;
        private double _gpa;
        //Placeholder varibale for the mold ... for later contructor use as a filter
        //public Student(string name, string id, int age, int yob, string email, double gpa)
        //{
        //    // _<name> to replace this.name
        //    _name = name;
        //    _id = id;
        //    _age = age;
        //    _yob = yob;
        //    _email = email;
        //    _gpa = gpa;
        //}
        //Without Contructor(string name, string id, int age, int yob, string email, double gpa).
        //The compiler will create an Empty Contructor() (set all variable to their default value - string = null, int = 0)
        //When that happens, we can still create: new Student() with a default constructors
        public string GetName() => _name;
        public string GetEmail() => _email;

        public void ShowInfo()
        {
            Console.WriteLine(@$"Your personal infos => Name: {_name} | Age: {_age} | Birth: {_yob} | Email: {_email} | GPA: {_gpa}");
        }
        //Hypothesis: Object is created. And we want to update some variable
        public void SetGpa(double gpa) => _gpa = gpa;
        public void SetYob(int yob) => _yob = yob;
    }
}

