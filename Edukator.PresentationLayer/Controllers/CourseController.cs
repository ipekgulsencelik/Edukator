﻿using Edukator.BussinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Edukator.PresentationLayer.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ICategoryService _categoryService;

        public CourseController(ICourseService courseService, ICategoryService categoryService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _courseService.TGetCoursesWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem()
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();

            ViewBag.categories = values;

            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            _courseService.TInsert(course);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCourse(int id)
        {
            var value = _courseService.TGetByID(id);
            _courseService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            
            ViewBag.categories = values;
            var value = _courseService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCourse(Course course)
        {
            _courseService.TUpdate(course);
            return RedirectToAction("Index");
        }
    }
}