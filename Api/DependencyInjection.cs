namespace Api
{
    public static class DependencyInjection
    {
        public static void AddApi(this IServiceCollection services)
        {

        }
        public static void UseWebCors(this WebApplication app)
        {
            var url = "http://localhost:5173";
            // code your own to update your url based on your environment.
            // .. 
            // ..

            app.UseCors(options =>
            {
                options.WithOrigins(url).AllowAnyMethod().AllowAnyHeader();
            });
        }
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app)
        {
            // code your own global exception
        }
    }
}
