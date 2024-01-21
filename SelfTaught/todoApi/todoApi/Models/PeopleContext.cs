using System;
using Microsoft.EntityFrameworkCore;
using todoApi.Models.DTO;

namespace todoApi.Models
{
	public class PeopleContext : DbContext
	{
        public PeopleContext(DbContextOptions<People>)
        {

        }

        public DbSet<People> People { get; set; } = null!;
    }
}


