using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Models.Users
{
    public enum Gender
    {
        [Display(Name = "None")]
        None = 0,

        [Display(Name = "Male")]
        Male = 1,

        [Display(Name = "Female")]
        Female = 2,

        [Display(Name = "Other")]
        Other = 3,
    }
}