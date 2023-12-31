using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using TT_GeeksForLess_Vladyslav_Slyzkoukhyi;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        ObjectToSerialize serializedObjects = new ObjectToSerialize();        

        string jsonWrite = JsonConvert.SerializeObject(serializedObjects, Formatting.Indented);
        File.WriteAllText(@"result.json", jsonWrite);

        var jsonToDB = new TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Models.Serializer()
        {
            JsonText = jsonWrite
        };

        var configuration = new ConfigurationBuilder()
            .SetBasePath(builder.Environment.ContentRootPath)
            .AddJsonFile("appsettings.json")
            .Build();
        
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddDbContext<FolderContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        builder.Services.AddControllersWithViews();

        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        
        app.Run();
    }    
}