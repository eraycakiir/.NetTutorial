using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models;
using E_Ticaret.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using System.Security.Claims;

namespace E_Ticaret.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
		public OrderVM OrderVM { get; set; }
		public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    
        public IActionResult Index()
        {
            IEnumerable<OrderProduct> orderProducts;

            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            orderProducts = _unitOfWork.OrderProduct.GetAll(u => u.AppUserId == claim.Value);
            return View();

        }
    }
}
