using ArmchairTreasureHunt.Models;
using ArmchairTreasureHunt.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace ArmchairTreasureHunt.Controllers
{
	[Authorize]
	public class GameController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly UserManager<IdentityUser> _userManager;

		public GameController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
		{
			_context = context;
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Notebook1()
		{
			var n1 = new Notebook1();
			return View(n1);
		}
        public IActionResult Notebook2()
        {
            var n2 = new Notebook2();
            return View(n2);
        }
		

		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CheckNotebook1([Bind("Id,Country,Password1,UserId")] Notebook1 notebook1)
		{
			if (notebook1.Country != null && notebook1.Password1 != null)
			{
				notebook1.Country = notebook1.Country.ToLower();
				notebook1.Password1 = notebook1.Password1.ToLower();
			}
			notebook1.UserId = _userManager.GetUserId(User);
			Notebook1 notebook1User = _context.Notebook1.Where(x => x.UserId == notebook1.UserId).FirstOrDefault();

			

			if (ModelState.IsValid && notebook1?.Country == "new zealand" && notebook1.Password1 == "maori" && notebook1User == null)
			{
				_context.Add(notebook1);
				await _context.SaveChangesAsync();
				TempData["success"] = "Correct! You found Key I!";
				return RedirectToAction(nameof(Notebook1));

			}
			else if (ModelState.IsValid && notebook1?.Country == "new zealand" && notebook1.Password1 == "maori" && notebook1User != null)
			{
				TempData["exists"] = "You have already Key I!"; 
				return RedirectToAction(nameof(Notebook1));

			}

			else
			{
				TempData["error"] = "Incorrect!";
				return RedirectToAction(nameof(Notebook1));

			}
			return View(notebook1);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CheckNotebook2([Bind("Id,Planet,Password2,UserId")] Notebook2 notebook2)
		{
			if (notebook2.Planet != null && notebook2.Password2 != null)
			{
				notebook2.Planet = notebook2.Planet.ToLower();
				notebook2.Password2 = notebook2.Password2.ToLower();
			}
			notebook2.UserId = _userManager.GetUserId(User);
			Notebook2 notebook2User = _context.Notebook2.Where(x => x.UserId == notebook2.UserId).FirstOrDefault();

			

			if (ModelState.IsValid && notebook2?.Planet == "toi" && notebook2.Password2 == "700d" && notebook2User == null)
			{
				_context.Add(notebook2);
				await _context.SaveChangesAsync();
                TempData["success"] = "Correct! You found Key II!";
                return RedirectToAction(nameof(Notebook2));

			}
			else if (ModelState.IsValid && notebook2?.Planet == "toi" && notebook2.Password2 == "700d" && notebook2User != null)
			{
                TempData["exists"] = "You have already Key II!";
                return RedirectToAction(nameof(Notebook2));

			}

			else
			{
                TempData["error"] = "Incorrect!";
                return RedirectToAction(nameof(Notebook2));

			}
			return View(notebook2);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Treasure([Bind("Id,Country,Password1,Password2,UserId")] Notebook3 notebook3)
		{
			if (notebook3.Country != null && notebook3.Password1 != null && notebook3.Password2 != null)
			{
				notebook3.Country = notebook3.Country.ToLower();
				notebook3.Password1 = notebook3.Password1.ToLower();
				notebook3.Password2 = notebook3.Password2.ToLower();
			}
			notebook3.UserId = _userManager.GetUserId(User);
			Notebook3 notebook3User = _context.Notebook3.Where(x => x.UserId == notebook3.UserId).FirstOrDefault();

			

			if (ModelState.IsValid && notebook3?.Country == "israel" && notebook3.Password1 == "maori" && notebook3.Password2 == "700d" && notebook3User == null)
			{
				_context.Add(notebook3);
				await _context.SaveChangesAsync();
				TempData["treasure"] = "Bingo! - opening Treasure Chest!";
				return View(Treasure);

			}
			else if (ModelState.IsValid && notebook3?.Country == "israel" && notebook3.Password1 == "maori" && notebook3.Password2 == "700d" && notebook3User != null)
			{
				TempData["treasure1"] = "Opening your Treasure Chest.";
				return View(Treasure);

			}

			else
			{
                TempData["error"] = "Incorrect!";
                return RedirectToAction(nameof(Notebook3));

			}
			return View(notebook3);
		}


		public IActionResult Notebook3(Notebook1 notebook1, Notebook2 notebook2)

		{
            var n3 = new Notebook3();
            notebook1.UserId = _userManager.GetUserId(User);
			notebook2.UserId = _userManager.GetUserId(User);
			Notebook1 notebook1User = _context.Notebook1.Where(x => x.UserId == notebook1.UserId).FirstOrDefault();
			Notebook2 notebook2User = _context.Notebook2.Where(x => x.UserId == notebook2.UserId).FirstOrDefault();
			if (notebook1User != null && notebook2User !=null)
			{
				return View(n3);
			}
			else
				TempData["noaccess"] = "You need both Keys to open Notebook III!";
			return RedirectToAction(nameof(Index));
		}

	}
}
