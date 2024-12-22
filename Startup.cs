using xUnitWebApplication.Interface;
using xUnitWebApplication.Services;

namespace xUnitWebApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddSingleton<IEmailServices, EmailServices>();
            services.AddSingleton<IPrinterServices, PrinterServices>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
        }
    }
}
