using E_Ticaret.Data.Repository;
using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models;
using E_Ticaret.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Ticaret.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class ProductController : Controller
    {
        private readonly  IUnitOfWork _unitOfWork;
        private readonly  IWebHostEnvironment _hostEnvirorment;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnviroment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvirorment = hostEnviroment;
        }

        public IActionResult Index()
        {
            var productList = _unitOfWork.Product.GetAll();
            return View(productList);
        }
        public IActionResult Crup(int? id)
        {
            ProductVm productVm = new()
            {
                Product = new(),
                CategoryList= _unitOfWork.Cateogory.GetAll().Select(l=> new SelectListItem
                {
                    Text= l.Name,
                    Value=l.Id.ToString()
                })
            };

            if(id == null||id<=0)
            {
                return View(productVm);
            }
             productVm.Product = _unitOfWork.Product.GetFirstOrDefault(x => x.Id == id);
            if(productVm.Product == null)
            {
                return View(productVm);
            }
            return View(productVm);
        }
        [HttpPost]
        public IActionResult Crup(ProductVm productVm,IFormFile file)
        {
            string wwwRootPath = _hostEnvirorment.WebRootPath;
            
            if(file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploadRoot = Path.Combine(wwwRootPath, @"img\products");
                var extension = Path.GetExtension(file.FileName);

                if(productVm.Product.Picture != null)
                {
                    var oldPicPath = Path.Combine(wwwRootPath, productVm.Product.Picture);
                    if(System.IO.File.Exists(oldPicPath))
                    {
                        System.IO.File.Delete(oldPicPath);
                    }
                }

                using (var fileStream = new FileStream(Path.Combine(uploadRoot,fileName+extension),
                    FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                productVm.Product.Picture=@"\img\products\"+fileName+extension; 
            }

            if(productVm.Product.Id <=0)
            {
                _unitOfWork.Product.Add(productVm.Product);
            }
            else
            {
                _unitOfWork.Product.Update(productVm.Product);
            }
                _unitOfWork.Save();
                return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id<=0)
            {
                return NotFound();
            }
            var product = _unitOfWork.Product.GetFirstOrDefault(x=>x.Id == id);

            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
