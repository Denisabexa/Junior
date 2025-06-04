namespace UsersService
{
    public class Program
    {
		public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			AppConfiguration.AddDBContext(builder.Services);

			AppConfiguration.AddServices(builder.Services);

			builder.Services.AddControllers();

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			// Add controllers
			builder.Services.AddControllers();

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
				app.UseSwagger();
				app.UseSwaggerUI();

				// Seed DB
				AppConfiguration.SeedDB(app.Services);
			}

            app.UseHttpsRedirection();

            app.UseAuthorization();

			app.MapControllers();

            app.Run();
		}
	}
}
