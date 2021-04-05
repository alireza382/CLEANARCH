using ClaenArch.Application.Interfaces;
using ClaenArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;
using CleanArch.Domain.Interfaces;

namespace ClaenArch.Application.Services
{
     public class CourseService : ICourseService
    {

        private ICourseRepository _courserepository;


        public CourseService(ICourseRepository courseRepository)
        {
            this._courserepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {

                Courses = _courserepository.GetCourses()
            };
        }
    }
}
