using ConsoleXLAPI.Interfaces;
using ConsoleXLAPI.Models;
using ConsoleXLAPI.Repository;
using System.Reflection;

namespace ConsoleXLAPI
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            string assemblyPath = "C:\\cdnapi\\cdn_api20231.net.dll";
            try
            {
                Assembly customAssembly = Assembly.LoadFrom(assemblyPath);
                var types = customAssembly.GetTypes().Where(type => type.Namespace == "cdn_api").ToList();

                foreach (var type in types)
                {
                }
            }
            catch (Exception ex)
            {
            }


            Type cdnApiType = typeof(XLKontrahentInfo);
            foreach (var item in cdnApiType.GetProperties())
            {
            }

            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "XL API integrator", Version = "v1" });
            });
            builder.Services.AddScoped<XLControllers.XLContractorsController>();
            builder.Services.AddScoped<XLControllers.XLLoginController>();
            builder.Services.AddScoped<XLControllers.XLCategoriesController>();
            builder.Services.AddScoped<XLControllers.XLCommoditiesController>();
            builder.Services.AddScoped<XLControllers.XLDocumentsController>();

            builder.Services.AddScoped<ICommoditiesRepository, CommoditiesRepository>();
            builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            builder.Services.AddScoped<IContractorsRepository, ContractorsRepository>();
            builder.Services.AddScoped<ILoginRepository, LoginRepository>();
            builder.Services.AddScoped<IDocumentsRepository, DocumentsRepository>();
            builder.Services.AddSingleton<IMainControllerRepository, MainControllerRepository>();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            var app = builder.Build();
            
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseWebSockets();
            app.MapControllers();

            app.Run();
        
        }
    }
}