using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models;
using E_Ticaret.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_Ticaret.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CartVM CartVM { get; set; }  
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            CartVM = new CartVM()
            {
                ListCart = _unitOfWork.Cart.GetAll(p=>p.AppUserId==claim.Value,includeProperties:"Product"),
                OrderProduct=new()
            };
            foreach(var cart in CartVM.ListCart)
            {
                cart.Price = cart.Product.Price + cart.Count;
                CartVM.OrderProduct.OrderPrice += (cart.Price);
            }
            return View(CartVM);
        }

        public IActionResult  Order()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                CartVM = new CartVM()
                {
                    ListCart = _unitOfWork.Cart.GetAll(p => p.AppUserId == claim.Value, includeProperties: "Product"),
                    OrderProduct = new()
                };
            CartVM.OrderProduct.AppUser = _unitOfWork.AppUser.GetFirstOrDefault(u => u.Id == claim.Value);

            CartVM.OrderProduct.Name = CartVM.OrderProduct.AppUser.FullName;
            CartVM.OrderProduct.CellPhone = CartVM.OrderProduct.AppUser.CellPhone;
            CartVM.OrderProduct.Address = CartVM.OrderProduct.AppUser.Adress;
            CartVM.OrderProduct.PostalCode = CartVM.OrderProduct.AppUser.PostaCode;
            foreach (var cart in CartVM.ListCart)
            {
                cart.Price = cart.Product.Price + cart.Count;
                CartVM.OrderProduct.OrderPrice += (cart.Price);
            }
            return View(CartVM);
        }

        [HttpPost]
        [ActionName("Order")]
        [ValidateAntiForgeryToken]
        public IActionResult OrderPost(CartVM cartVM)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            CartVM = new CartVM()
            {
                ListCart = _unitOfWork.Cart.GetAll(p => p.AppUserId == claim.Value, includeProperties: "Product"),
                OrderProduct = new()
            };
            AppUser appUser = _unitOfWork.AppUser.GetFirstOrDefault(u => u.Id == claim.Value);
            CartVM.OrderProduct.AppUser = appUser;
            CartVM.OrderProduct.DateTime=System.DateTime.Now;
            CartVM.OrderProduct.AppUserId = claim.Value;
            CartVM.OrderProduct.Name = cartVM.OrderProduct.Name;
            CartVM.OrderProduct.CellPhone = CartVM.OrderProduct.AppUser.CellPhone;
            CartVM.OrderProduct.Address = cartVM.OrderProduct.Address;
            CartVM.OrderProduct.PostalCode = cartVM.OrderProduct.PostalCode;
            CartVM.OrderProduct.OrderStatus = "Ordered";
            foreach (var cart in CartVM.ListCart)
            {
                cart.Price = cart.Product.Price + cart.Count;
                CartVM.OrderProduct.OrderPrice += (cart.Price);
            }
            _unitOfWork.OrderProduct.Add(CartVM.OrderProduct);
            _unitOfWork.Save();

            foreach(var cart in CartVM.ListCart)
            {
                OrderDetails orderDetails = new()
                {
                    ProductId = cart.ProductId,
                    OrderProductId = CartVM.OrderProduct.Id,
                    Price = cart.Price,
                    Count = cart.Count,
                };
                _unitOfWork.OrderDetails.Add(orderDetails);
                _unitOfWork.Save();
            }

            List<Cart>Carts=_unitOfWork.Cart.GetAll(u=>u.AppUserId==CartVM.OrderProduct.AppUserId).ToList();
            _unitOfWork.Cart.RemoveRange(Carts);
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index), "Home", new { area = "Customer" });
        }
    }
    
}
