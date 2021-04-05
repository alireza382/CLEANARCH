using ClaenArch.Application.Interfaces;
using ClaenArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;


        public CourseController(ICourseService courseService)
        {

            this._courseService = courseService;

        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            
            return View();
        }
    }
}
