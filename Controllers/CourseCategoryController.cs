using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using E_learing.Models;
using E_learing.Repository;
using E_learing.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace E_learing.Controllers
{
    // [Route("[controller]")]
    public class CourseCategoryController : Controller
    {
        private ICourseCategoryRepository _courseCategoryRepo;

        public CourseCategoryController(ICourseCategoryRepository courseCategoryRepo)
        {
            _courseCategoryRepo = courseCategoryRepo;
        }

        public IActionResult Index()
        {
            List<CourseCategory> courseCategory = _courseCategoryRepo.GetAll().ToList();
            return View(courseCategory);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseCategory obj)
        {
            if (obj.Name.Length <= 1)
            {
                ModelState.AddModelError("name", "Name must be more than one character");
            }
            if (ModelState.IsValid)
            {
                _courseCategoryRepo.Add(obj);
                _courseCategoryRepo.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CourseCategory? CategoryFromDb = _courseCategoryRepo.Get(u => u.Id == id);
            return View(CategoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(CourseCategory obj)
        {
            if (obj.Name.Length <= 1)
            {
                ModelState.AddModelError("name", "Name must be more than one character");
            }
            if (ModelState.IsValid)
            {
                _courseCategoryRepo.Update(obj);
                _courseCategoryRepo.Save();
                TempData["success"] = "Category Updated Successfuly";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CourseCategory? CategoryFromDb = _courseCategoryRepo.Get(u => u.Id == id);

            return View(CategoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            CourseCategory? obj = _courseCategoryRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _courseCategoryRepo.Remove(obj);
            _courseCategoryRepo.Save();
            TempData["success"] = "Category deleted successfuly";

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}