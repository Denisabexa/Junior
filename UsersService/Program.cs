
using Microsoft.EntityFrameworkCore;
using UsersService.DBContext;
using UsersService.Models;

namespace UsersService
{
    public class Program
    {

		//TODO
		//1. AddContext in app configuration
		//2. fac seed la db si cu 2 order
		//3. implementeaza GetOrdersByUserId
		public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddDbContext<UsersDbContext>(options =>
	        options.UseInMemoryDatabase("UsersDb"));

			AppConfiguration.AddServices(builder.Services);

			builder.Services.AddControllers();

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			// Add controllers
			builder.Services.AddControllers();


			var app = builder.Build();

			// Seed DB
			AppConfiguration.SeedDB(app.Services);

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
				app.UseSwagger();
				app.UseSwaggerUI();
			}

            app.UseHttpsRedirection();

            app.UseAuthorization();


			app.MapControllers();

            app.Run();


		}

	}
}
