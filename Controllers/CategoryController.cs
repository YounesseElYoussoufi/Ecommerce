using Ecomproject.Data.Service;
using Ecomproject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecomproject.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allCategory = await _service.GetAllAsync();
            return View(allCategory);
        }

        //GET: Companies/details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var CategoryDetails = await _service.GetByIdAsync(id);
            if (CategoryDetails == null) return View("NotFound");

            return View(CategoryDetails);
        }

        //GET: Companies/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("CategoryName,CategoryLogoURL")] Category Category)
        {
            if (!ModelState.IsValid) return View(Category);

            await _service.AddAsync(Category);
            return RedirectToAction(nameof(Index));
        }

        //GET: Companies/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var CategoryDetails = await _service.GetByIdAsync(id);
            if (CategoryDetails == null) return View("NotFound");
            return View(CategoryDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryName,CategoryLogoURL")] Category Category)
        {
            if (!ModelState.IsValid) return View(Category);

            if (id == Category.Id)
            {
                await _service.UpdateAsync(id, Category);
                return RedirectToAction(nameof(Index));
            }
            return View(Category);
        }

        //GET: Companies/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var CompanyDetails = await _service.GetByIdAsync(id);
            if (CompanyDetails == null) return View("NotFound");
            return View(CompanyDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var CompanyDetails = await _service.GetByIdAsync(id);
            if (CompanyDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

