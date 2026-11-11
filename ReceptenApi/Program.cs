
namespace ReceptenApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // “0.4 en 0.5 zijn het aanmelden van services, en dat moet gebeuren vóór Build(),
            // want daar wordt de app gebouwd met alles wat is aangemeld.
            // 0.7 en 0.8 bepalen wat er gebeurt bij een request, en dat kan pas na Build(), als de app er is.”

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
