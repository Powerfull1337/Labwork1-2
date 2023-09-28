using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1lab.Data;
using WebApplication1lab.Models;

namespace WebApplication1lab.Controllers
{
	public class HomeController : Controller
	{
		private readonly MovieContext _context;

		public HomeController(MovieContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var courses = from mov in _context.Movies
						  select mov;
			return View(await courses.ToListAsync());
		}

		public async Task<IActionResult> Buy(int id)
		{
			var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
			return View(movie);
		}

		[HttpPost]
		public async Task<IActionResult>  Buy(string person, string address)
		{

			return RedirectToAction("Confirm", new { person, address });
		}


		public IActionResult Confirm(string person, string address)
		{
			var purchase = new Purchase
			{
				Person = person,
				Address = address
			};

			return View(purchase);
		}
	}
}