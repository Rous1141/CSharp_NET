using System;
namespace StudentV5.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public double Gpa { get; set; }

        //EVEN A QUICKER METHOD TO CREATE PROPERTY AND GET-SET
        // prop _tab _tab
        //Auto Implimented Property
        //Java don't have an official method like this, must use a 3rd site dependency - Lombok

        //Database first!, with a single code, the WHOLE Database will be convert into a class. Auto Prop

        //Rule of compiler: .var is GET | .var = is SET

        public void ShowAll() => Console.WriteLine($"{1} | {2} | {3} | {4} | {5}",Id,Name,Age,Email,Gpa);
        public void ShowProfile() => Console.WriteLine($"{Name} | {Id} | {Age} | {Email} | {Gpa}");
        public override string ToString() => $"{Name} | {Id} | {Age} | {Email} | {Gpa}";
        // @override -> Java
        // new | @override -> C#

    }
}

