using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ArmchairTreasureHunt.Models
{
	public class Notebook3
	{
		public int Id { get; set; }
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Required]
        [StringLength(20, ErrorMessage = "20 characters maximum")]
        public string? Country { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$")]
        [StringLength(20, ErrorMessage = "20 characters maximum")]
        public string? Password1 { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        [Required]
        [StringLength(20, ErrorMessage = "20 characters maximum")]

        public string? Password2 { get; set; }
		public string? UserId { get; set; }

		public virtual IdentityUser? User { get; set; }
	}
}

