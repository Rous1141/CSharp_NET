using StudentV1.Entities;

namespace StudentV1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CreateANewStudentV1();
        CreateANewStudentV2();
        CreateANewStudentV3();
        CreateANewStudentV4();
        Console.Read();

    }
    static void CreateANewStudentV4()
    {
        //New Style Method with Named Arguement - sending data in random order but you must call the data by their name: <Name> : <Value>
        Student reimu = new(birthYear:2002,gpa:2.2, id:"Gen1", name:"Hakurei Reimu", email:"reimu@gmail.com");
        // reimu is a object variable
        // new Student is a complex object

        reimu.ShowProfile();
    }

    static void CreateANewStudentV3()
    {
        //New Style Method simplify 'new' object contructor;
        Student reimu = new ("Gen1", "Hakurei Reimu", "reimu@gmail.com", 2002, 3);
        // reimu is a object variable
        // Student is a complex object

        reimu.ShowProfile();
    }

    static void CreateANewStudentV2()
    {
        //New Style Method using var -> auto datatype detector
        var reimu = new Student("Gen1", "Hakurei Reimu", "reimuHaku@gmail.com", 2002, 2.8);
        // reimu is a object variable
        // new Student is a complex object

        reimu.ShowProfile();
    }

    /// <summary>
    /// Create a complex value with traditional method. We human tend to name reverything surrounding them, after describe them!!! This is a reimu (name, age, job, power...)
    /// </summary>
    static void CreateANewStudentV1()
    {
        Student reimu = new Student("Gen1", "Hakurei Reimu","Rei@gmail.com",2002,2.5);
        // reimu is a object variable
        // new Student is a complex object

        reimu.ShowProfile();
    }
}

