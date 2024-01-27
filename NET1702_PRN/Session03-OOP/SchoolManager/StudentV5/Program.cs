using StudentV5.Entities;

namespace StudentV5;

class Program
{
    static void Main(string[] args)
    {
        //There is the another way to new a class
        Student stu = new Student(); //ctor default
        //Everything is empty

        //Quick Set Get
        stu.Name = "Reimu";
        stu.Age = 20;
        stu.Email = "Haku@gmail.com";
        stu.Gpa = 8.9;

        Console.WriteLine($@"Your infos: Name: {stu.Name} | Age: {stu.Age} | GPA: {stu.Gpa}");
        

        //OR EVEN A BETTER METHOD
        Student stu2 = new Student() {Name="Sanae", Gpa=9.2, Age=19, Email="kochiya@gmail.com" }; // New Method for GET - SET -> Quick and Clean
        //Create a class using Property Initiation => Create and Set variable value for object
        // Not the same as Name Arguement
        Console.WriteLine($@"Your infos: Name: {stu2.Name} | Age: {stu2.Age} | GPA: {stu2.Gpa}");

        Console.Read();
    }
}

