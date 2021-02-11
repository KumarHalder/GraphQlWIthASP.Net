using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlDotNet.Data;
using GraphQlDotNet.Interface;
using GraphQlDotNet.Mutation;
using GraphQlDotNet.Query;
using GraphQlDotNet.Schema;
using GraphQlDotNet.Services;
using GraphQlDotNet.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GraphQlDotNet
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
            services.AddControllers();
            services.AddTransient<IMenu, MenuService>();
            services.AddTransient<ISubMenu, SubMenuService>();
            services.AddTransient<IReservation, ReservationService>();
            services.AddTransient<MenuType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<ReservationType>();
            services.AddTransient<RootQuery>();
            services.AddTransient<MenuQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<MenuMutation>();
            services.AddTransient<SubmenuMutation>();
            services.AddTransient<ReservationMutation>();
            services.AddTransient<RootMutation>();
            services.AddTransient<MenuInputType>();
            services.AddTransient<SubmenuInputType>();
            services.AddTransient<ReservationInputType>();
            services.AddTransient<ISchema,RootSchema>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();
            
            services.AddDbContext<GraphQlDbContext>(option =>
                option.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "GraphQlDotNet", Version = "v1"});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GraphQlDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
           
            }

            dbContext.Database.EnsureCreated();
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
        }
    }
}