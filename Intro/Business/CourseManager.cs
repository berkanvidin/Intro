﻿using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    
    public List<Course> getAll()
    {
        // business rules
        CourseDal courseDal = new CourseDal();

        return courseDal.GetAll();
    }
}
