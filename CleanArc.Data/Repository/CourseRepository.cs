using CleanArc.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {

        private UniversityDBContext _universityDbcontext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            this._universityDbcontext = universityDBContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _universityDbcontext.Courses;
        }
    }
}
