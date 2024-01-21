using System;
namespace ConnectingDatabase
{
	public class People
	{
        public int Id { get; set; }
		public String Name { get; set; }
		public int Age { get; set; }
		public String job { get; set; }

        public People(int id, string name, int age, string job)
        {
            Id = id;
            Name = name;
            Age = age;
            this.job = job;
        }
    }
}

