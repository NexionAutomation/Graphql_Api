using GraphQl.DATA.API.Models;
using GraphQl.DATA.API.PO.Model;
using GraphQL_HotChoclate_EFCore.GraphQL;
using GraphQL_HotChoclate_EFCore.Models;
using GraphQL_HotChoclate_EFCore.Services;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_HotChoclate_EFCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            #region Connection String
            services.AddDbContext<poContext>(item => item.UseSqlServer(Configuration.GetConnectionString("PO")));
            services.AddDbContext<crmContext>(item => item.UseSqlServer(Configuration.GetConnectionString("CRM")));
            #endregion
            //services.AddScoped<Query>();
            //services.AddScoped<Mutuation>();
            //services.AddScoped<IEmployeeService,EmployeeService>();
            //services.AddGraphQL(c => SchemaBuilder.New().AddServices(c).AddType<GraphQLTypes>()
            //                                                            .AddQueryType<Query>()
            //                                                            .AddMutationType<Mutuation>()
            //                                                             .Create());




            services.AddGraphQLServer().AddQueryType<PoUserServices>(q=>q.Name("Query")).AddFiltering().AddSorting().AddType<UploadType>(); ;
            services.AddGraphQLServer().AddMutationType<PoUserMutation>(q => q.Name("Mutuation")).AddType<UploadType>(); ;
            
            //services.AddGraphQLServer().AddQueryType<CRMUserServices>();
            services.AddTransient<poContext>();
            services.AddTransient<crmContext>();
            services.AddTransient<PoUserServices>();
            services.AddTransient<PoUserMutation>();

            services.AddCors();
            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions
                {
                    QueryPath = "/GraphQL",
                    Path = "/playground"
                });
            }
            app.UseCors(builder => builder
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());


          
            app.UseGraphiQLServer();
            //app.UseRouting();

            app
                .UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapGraphQL();
                });
        }
    }
}
