﻿using e_ticket.Data;
using e_ticket.Data.Services;
using e_ticket.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
		public  async Task <IActionResult> Create() 
		{
			var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
			ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
			ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id","FullName");
			ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

			return View();
		}
		[HttpPost]
		
		public async Task<IActionResult>Create(NewMovieVM movie)
		{
			if (!ModelState.IsValid)
			{
                var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
                return View(movie);
			}
			await _service.AddMewMovieAsync(movie);
			return RedirectToAction( nameof(Index));
		}
	}
}
