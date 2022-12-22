﻿using e_ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_ticket.Controllers
{
	public class ProducersController : Controller
	{
		private readonly AppDbContext _context;
		public ProducersController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var allProducers = await _context.Producers.ToListAsync();
			return View(allProducers);
		}
	}
}
