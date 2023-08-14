using Microsoft.Build.Framework;

namespace TraversalCoreProject.Models
{
    public class UserSignInModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}
