using Microsoft.AspNetCore.Identity;

namespace DotnetCore_MVC.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName {  get; set; } = string.Empty;
        public string LastName {  get; set; } = string.Empty;
    }
}
