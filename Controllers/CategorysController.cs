
using Microsoft.AspNetCore.Mvc;

using MvcCrud.Data;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
  
    public class CategorysController : Controller
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();


// GET: Categorys
        public IActionResult Index()
        {
            var categories = _dbContext.Categorys.ToList();
            return View("Index", categories);
        }

 // GET: Categorys/Create
        public IActionResult Create()
        {
            return View();
        }

    // POST: Categorys/Store
        public IActionResult Store (Category category)
        {
            _dbContext.Categorys.Add(category);
            _dbContext.SaveChanges();
             var categories = _dbContext.Categorys.ToList();
            return RedirectToAction("Index" , categories);
        }
    // GET: Categorys/Edit
        public IActionResult Edit(int id)
        {
            var category = _dbContext.Categorys.Find(id);
            return View(category);
        }

    // POST: Categorys/Update
        public IActionResult Update(Category category)
        {
            _dbContext.Categorys.Update(category);
            _dbContext.SaveChanges();
             var categories = _dbContext.Categorys;
            return RedirectToAction("Index" , categories);
        }
    // GET: Categorys/Details
           public IActionResult Details(int id)
        {
            var category = _dbContext.Categorys.Find(id);
            return View(category);
        } 

    // GET: Categorys/Delete
        public IActionResult Delete(int id)
        {
            var category = _dbContext.Categorys.Find(id);
            if (category != null)
            {
                _dbContext.Categorys.Remove(category);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}