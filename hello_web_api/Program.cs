namespace hello_web_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Service(Container)
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.SwaggerGen();


            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
