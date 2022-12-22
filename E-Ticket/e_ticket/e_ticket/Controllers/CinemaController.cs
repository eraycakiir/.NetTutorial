using e_ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_ticket.Controllers
{
	public class CinemaController : Controller
	{
		private readonly AppDbContext _context;
		public CinemaController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var allProducers = await _context.Cinemas.ToListAsync();
			return View();
		}
	}
}
