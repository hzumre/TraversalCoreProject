using Microsoft.Build.Framework;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
namespace TraversalCoreProject.Models
{
	public class UserRegisterVM
	{
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your surname")]
		public string SurName { get; set; }
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your username")]
		public string UserName { get; set; }
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your mail")]
		public string Mail { get; set; }
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your password")]
		public string Password { get; set; }

		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter your password again")]
		[Compare("Password", ErrorMessage = "Passwords are not compatible")]
		public string ConfirmPassword { get; set; }

	}
}
