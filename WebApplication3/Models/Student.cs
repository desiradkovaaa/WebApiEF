using System;
using System.Collections.Generic;
namespace WebApplication3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
