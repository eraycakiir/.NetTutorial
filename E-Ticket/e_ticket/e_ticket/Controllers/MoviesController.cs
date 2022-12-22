﻿using e_ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_ticket.Controllers
{
	public class MoviesController : Controller
	{
		private readonly AppDbContext _context;
		public MoviesController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var allProducers = await _context.Movies.ToListAsync();
			return View();
		}
	}
}