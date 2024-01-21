using System;
namespace todoApi.Models.DTO
{
	public class People
	{
        public People(int id, string? name, int age, string? job)
        {
            Id = id;
            Name = name;
            Age = age;
            Job = job;
        }

        public int Id { get; set; }
		public string? Name { get; set; }
		public int Age { get; set; }
		public string? Job { get; set; }
	}
}

