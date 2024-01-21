using System;
using Microsoft.EntityFrameworkCore;

namespace todoApi.Models
{
	//The DatabaseContet is the main class that coordinate functionaliy for a data model
	public class TodoContext : DbContext
	{
		public TodoContext(DbContextOptions<TodoContext> options)
			: base(options)
		{

		}

		public DbSet<TodoItem> TodoItems { get; set; } = null!;
	}
}

