using StudentV2.Entities;

namespace StudentV2;

class Program
{
    static void Main(string[] args)
    {
        var stu = new Student(); //Default Values Cannot be changed!!!
        //Proving The Default Values
        Student stu2 = new Student();
        stu2.ShowInfo();
        //Prove that Default Value Exist

        //Set command to update GPA
        stu2.SetGpa(8.6);
        stu2.ShowInfo();
       //Set command can overwrite the default constuctor
        Console.Read();
    }
}

