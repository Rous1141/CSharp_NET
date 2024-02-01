using System;
namespace StudentV6.Entities
{
	public class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public double Gpa { get; set; }

        public override string ToString()
        {
			return $"{Name} | {Age} | {Email} | {Gpa} |";
        }
    }
}

