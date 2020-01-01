using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace TestSwaggerWithMultiplePostsCore22
{
    public class Startup
    {
        public IHostingEnvironment HostingEnvironment { get; }

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            HostingEnvironment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            AddSwaggerGenService(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment() == false)
            {
                app.UseHsts();
            }

            app.UseMvc();
            app.UseHttpsRedirection();

            ConfigureSwagger(app);
        }

        private void AddSwaggerGenService(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.DescribeAllEnumsAsStrings();

                c.SwaggerDoc("v1", new Info { Title = "Values API", Version = "v1" });

                var filePath = Path.Combine(HostingEnvironment.ContentRootPath, ".xml");
                c.IncludeXmlComments(filePath);
            });
        }

        private void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "Swagger";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Values API V1");
            });
        }
    }
}
