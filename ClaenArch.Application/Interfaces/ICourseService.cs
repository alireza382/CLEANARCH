﻿using ClaenArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClaenArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
