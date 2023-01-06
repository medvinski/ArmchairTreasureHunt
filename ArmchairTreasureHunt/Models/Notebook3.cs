using Microsoft.AspNetCore.Identity;

namespace ArmchairTreasureHunt.Models
{
	public class Notebook3
	{
		public int Id { get; set; }
		public string? Country { get; set; }
		public string? Password1 { get; set; }

		public string? Password2 { get; set; }
		public string? UserId { get; set; }

		public virtual IdentityUser? User { get; set; }
	}
}

