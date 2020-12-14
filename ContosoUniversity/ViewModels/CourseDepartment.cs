using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.ViewModels
{
    public class CourseDepartment
    {
        public List<Course> Courses { get; set; }
        public Department Department { get; set; }
    }
}