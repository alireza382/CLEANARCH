using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClaenArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course>  Courses { get; set; }
    }
}
