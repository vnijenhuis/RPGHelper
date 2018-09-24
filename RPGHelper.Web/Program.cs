using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RPGHelper.Models.Users;
using RPGHelper.Web.Data;

namespace RPGHelper.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Build webhost.
            var webHost = CreateWebHostBuilder(args).Build();

            //Initialize database here
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetService<ApplicationDbContext>();
                    var userManager = services.GetService<UserManager<User>>();
                    var roleManager = services.GetService<RoleManager<Role>>();

                    //Initializers
                    DbInitializer.Intialize(context, userManager, roleManager);
                    ResourceInitializer.Initialize(context);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            //Run website
            webHost.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
