using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ArmchairTreasureHunt.Models
{
	public class Notebook1
	{

		[Key]
		public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Required]
        [StringLength(20, ErrorMessage = "20 characters maximum")]
        public string? Country { get; set; }
        [RegularExpression(@"^[a-zA-Z]*$")]
        [Required]
        [StringLength(20, ErrorMessage = "20 characters maximum")]
        public string? Password1 { get; set; } 

		public string? UserId { get; set; } 

		public virtual IdentityUser? User { get; set; }
	}
}
