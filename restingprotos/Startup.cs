using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using v4demo_simulation_rest.SignalRTest;

namespace v4demo_simulation_rest
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvc(options => {
                options.OutputFormatters.Insert(0, new ProtobufOutputFormatter());
            });
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info() {
                    Version = "v1",
                    Title = "Simulation Example 2 kul msg",
                    Description = "Also see https://github.com/jensderdaele/v4dprotos for msg schemas & generation of serialization code",
                    TermsOfService = "None",
                    Contact = new Contact() {
                        Name = "Jens",
                        Email = "jens.derdaele@kuleuven.be",
                        Url = ""
                    }
                });
            });
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseHsts();
            }
            //app.UseStaticFiles(new StaticFileOptions() {
            //    FileProvider =
            //        new PhysicalFileProvider("V:\\geomatics\\projects\\V4Design\\1. Content\\Upload Nico Heise"),
            //    RequestPath = "/staticfilestest"
            //});
            app.UseHttpsRedirection();
            app.UseSignalR(routes => {
                routes.MapHub<ProgressReport>("/progress");
            });
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

        }
    }
}
