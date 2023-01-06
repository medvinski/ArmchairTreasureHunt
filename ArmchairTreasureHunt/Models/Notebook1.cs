using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ArmchairTreasureHunt.Models
{
	public class Notebook1
	{

		[Key]
		public int Id { get; set; }
        [Display(Name = "Exercise name")]
        [Required(ErrorMessage="Guess country!")]
		public string? Country { get; set; }
		[Required(ErrorMessage = "Guess password!")]
		public string? Password1 { get; set; } 

		public string? UserId { get; set; } 

		public virtual IdentityUser? User { get; set; }
	}
}
