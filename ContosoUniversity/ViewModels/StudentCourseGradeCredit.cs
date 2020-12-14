using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.ViewModels
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class StudentCourseGradeCredit
    {
       public string StudentName { get; set; }
        public string CourseTitle { get; set; }
        public string DepartmentName { get; set; }
        public int CourseCredit { get; set; }
        public Grade? EnrollementGrade { get; set; }
    }
}