using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TD_ApplicationCore.Interfaces.Repository;
using TD_ApplicationCore.Interfaces.Services;
using TD_ApplicationCore.Services;
using TD_Infrastructure.Data;
using TD_Infrastructure.Repositories;

namespace TD_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseInMemoryDatabase("TD_DataBase-inMemory").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IEscolaService, EscolaService>();
            services.AddScoped<IEscolaRepository, EscolaRepository>();
            services.AddScoped<ITurmaService, TurmaService>();
            services.AddScoped<ITurmaRepository, TurmaRepository>();
            
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
