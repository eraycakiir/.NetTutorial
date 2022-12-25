using e_ticket.Data;
using e_ticket.Data.Services;
using e_ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_ticket.Controllers
{
	public class CinemasController : Controller
	{
		private readonly ICinemasService _serivce;
		public CinemasController(ICinemasService service)
		{
			_serivce = service;
		}

		public async Task<IActionResult> Index()
		{
			var allCinemas = await  _serivce.GetAllAsync();
			return View(allCinemas);
		}

        //Get; Cinemas / Create

        public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create([Bind("Logo,Name,Description")]Cinema cinema)
		{
			if(!ModelState.IsValid)return View(cinema);
			await _serivce.AddAsync(cinema);
			return RedirectToAction(nameof(Index));
			
		}

		//Details

		public async Task <IActionResult>Details (int id)
		{
			var cinemaDetails =  await _serivce.GetByIdAsync(id);
			if (cinemaDetails == null) return View("NotFound");
			return View(cinemaDetails);
		}

        //Edit
        public async  Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _serivce.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _serivce.UpdateAsync(id,cinema);
            return RedirectToAction(nameof(Index));

        }

        //Delete

        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _serivce.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
			var cinemaDetails = await _serivce.GetByIdAsync(id);
			if (cinemaDetails == null) return View("NotFound");

			await _serivce.DeleteAsync(id);

			return RedirectToAction(nameof(Index));

        }


    }
}
