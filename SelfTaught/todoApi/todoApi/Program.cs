
using Microsoft.EntityFrameworkCore;
using todoApi.DatabaseConnection;
using todoApi.Models;
using todoApi.Models.API;


namespace todoApi;

public class Program
{
    public static void Main(string[] args)
    {

        //Some localhost webapp will be block by a CORS (Cross-Origin Requests) policy
        //You need to enable this or you have to host the Front End somewhere not localhost (on free server hostings)
        //Or You can disable this policy:
        var MyAllowSpecificOrigins = "_MyAllowSpecificOrigins";

        //**continue below...

        var builder = WebApplication.CreateBuilder(args);

        //**Code Continue:
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(
                policy =>
                {
                    policy.WithOrigins("http://localhost:3000");
                }
                );
        });


        //***continue below...

        // Add services to the container.
        builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        //Added more after creation
        builder.Services.AddDbContext<TodoContext>
            (
            opt => opt.UseInMemoryDatabase("Todolist")
            );
        builder.Services.AddDbContext<PeopleContext>
            (
               opt => opt.UseMySql(Configuration)
            ) ;
        //The preceding code:
        //Adds using directives.
        //Adds the database context to the DI container.
        //Specifies that the database context will use an in-memory database

        builder.Services.AddEndpointsApiExplorer();

        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        //***Code Continue:

        app.UseCors();

        //End of fixing CORS policy

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}

