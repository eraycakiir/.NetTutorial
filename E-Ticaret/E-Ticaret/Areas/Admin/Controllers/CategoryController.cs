using E_Ticaret.Data.Repository.IRepository;
using E_Ticaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = _unitOfWork.Cateogory.GetAll();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.Cateogory.Add(category);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit (int ? id)
        {
            if (id==null ||id <=0)
            {
                return NotFound();
            }
            var category = _unitOfWork.Cateogory.GetFirstOrDefault(x=> x.Id == id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Cateogory.Update(category);
                _unitOfWork.Save();
                return RedirectToAction("Index");   
            }
            return View(category);
        }          
        public  IActionResult Delete (int id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            var category = _unitOfWork.Cateogory.GetFirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _unitOfWork.Cateogory.Remove(category);
            _unitOfWork.Save();
            return RedirectToAction("Index");   
        }
    }
}
