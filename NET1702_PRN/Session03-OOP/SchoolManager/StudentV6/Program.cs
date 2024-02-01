using StudentV6.Entities;

namespace StudentV6;

class Program
{
    static void Main(string[] args)
    {
        PlayWithAnonymousV2();
        Console.Read();
    }

    //create an anonymous class
    static void PlayWithAnonymous()
    {
        //Beer Class with Properties: code,name,price,vol ->
        //var aBeer = new Beer() { ... };
        //var aBeer2 = new Beer(code: "001", name: "Suika", price: 200, vol: 300);
        //var aBeer3 = new Beer() {"Suika",200,300};
        var aBeer4 = new {Code="001",Name="Suika",
            Price=2_000,Vol=330 }; //Object initializer, no need a class
        // _ is a programer identification for LARGE numbers
                                                                       //It is a class, an anonymous class -> class Beer - properties: Code,Name,Price,Vol
                                                                       //Use this whne you get lazy with creating a whole class
                                                                       //But make sure it is a class with properties to back
                                                                       //The compiler during runtime will initialize a Class with an Object of those stats with the value writtien in it
                         // Anonymous Data Type
        Console.WriteLine("Calling the anonymous Object Beer:");
        Console.WriteLine(aBeer4); // Auto search for ToString
    }
    static void PlayWithAnonymousV2()
    {
        Student stu = new Student() { Name = "Sakuya", Age = 22, Email = "izayoi@gmail.com", Gpa = 8.9 }; // tradition way
        var stu2 = new Student() { Name = "Youmu", Age = 18, Email = "konpaku@gmail.com", Gpa = 7.2 }; // var auto type way
        var stu3 = new { Name = "Reimu", Age = 19, Email = "reimu@gmail.com", Gpa = 7.9 };//Anonymous Class
        var stu4 = new { stu2.Name, stu2.Email };//Anonymous Class to get only 2 props of stu2
        Console.WriteLine(stu);
        Console.WriteLine(stu2);
        Console.WriteLine(stu4);
        Console.WriteLine(stu3);
    }

}

