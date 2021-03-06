using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PhotoStock.Data;
using PhotoStock.DAL;
using Pomelo.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using PhotoStock.Services;
using PhotoStock.Mapping;

namespace PhotoStock
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<ApplicationDbContext>(opt => 
                opt.UseMySql(Configuration.GetConnectionString("DefaultConnection"), 
                ServerVersion.AutoDetect(Configuration.GetConnectionString("DefaultConnection"))));
            
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<ITextRepository, TextRepository>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<ITextService, TextService>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PhotoStock", Version = "v1" });
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PhotoStock v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            DbInitializer.Seed(context).Wait();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
