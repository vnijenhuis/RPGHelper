using System;
using Microsoft.AspNetCore.Identity;

namespace RPGHelper.Models.Users
{
    public class User : IdentityUser<Guid>
    {
        public string Firstname { get; set; }

        public string Preposition { get; set; }

        public string Surname { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public Gender Gender { get; set; }
    }
}
