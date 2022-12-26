using e_ticket.Data;
using e_ticket.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace e_ticket.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IMoviesService _service;
		public MoviesController(IMoviesService service)
		{
			_service = service;
		}

		public async Task<IActionResult> Index()
		{
			var allMovies = await _service.GetAllAsync(n =>n.Cinema);
			return View(allMovies);
		}

		//Get:Movies/Details/1

		public async Task<IActionResult> Details (int id)
		{
			var movieDetail = await _service.GetMovieByIdAsync(id);
			return View(movieDetail);
		}


		//Create
		public IActionResult Create() 
		{
			ViewData["Welcome"] = "Welcome to our store";
			ViewBag.Description = "This is the store description";

			return View();
		}
	}
}
