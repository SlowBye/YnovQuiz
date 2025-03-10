
using Microsoft.EntityFrameworkCore;
using quiz_ynov.Business;
using quiz_ynov.Business.Services;
using quiz_ynov.Controllers.Mappers;
using quiz_ynov.EntityFramework;

namespace quiz_ynov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IQuizService,QuizService>();
            builder.Services.AddScoped<QuizMapper>();
            builder.Services.AddScoped<IQuestionService, QuestionService>();
            builder.Services.AddScoped<QuestionMapper>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<CategoryMapper>();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string is missing");

            builder.Services.AddDbContext<ApplicationDbContext>(builder =>
            {
                builder.UseSqlServer(connectionString);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                var serviceScope = app.Services.CreateScope();
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context?.Database.EnsureCreated();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader());

            app.MapControllers();

            app.Run();
        }
    }
}
