using e_ticket.Data;
using e_ticket.Data.Services;
using e_ticket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace e_ticket.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorService _service;

		public ActorsController(IActorService service)
		{
			_service = service;
		}

		public async Task<IActionResult> Index()
		{
			var data = await _service.GetAllAsync();
			return View(data);
		}


		//Get:Actors/Create
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
			await _service.AddAsync(actor);
			return RedirectToAction(nameof(Index));
		}
        //Get:Actors/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }

}
