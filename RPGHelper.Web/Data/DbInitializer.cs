using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RPGHelper.Models.Users;

namespace RPGHelper.Web.Data
{
    public class DbInitializer
    {
        public static void Intialize(ApplicationDbContext context, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            context.Database.EnsureCreated();
        }
    }
}
