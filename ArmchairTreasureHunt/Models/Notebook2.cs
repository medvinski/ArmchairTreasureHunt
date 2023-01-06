using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ArmchairTreasureHunt.Models
{
    public class Notebook2
    {
        public int Id { get; set; }
        [RegularExpression(@"^[a-zA-Z]*$")]
        [Required]
        [StringLength(20, ErrorMessage = "20 characters maximum")]
        public string? Planet { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        [Required]
        [StringLength(20, ErrorMessage = "20 characters maximum")]
        public string? Password2 { get; set; }

		public string? UserId { get; set; }

		public virtual IdentityUser? User { get; set; }
	}

}

