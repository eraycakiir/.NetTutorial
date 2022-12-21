using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Areas.Admin.Controllers
{
    [Area("Admin")]
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
            var orderList = _unitOfWork.OrderProduct.GetAll(x => x.OrderStatus != "Teslim Edildi");
            return View(orderList);
        }
      
    }
}
