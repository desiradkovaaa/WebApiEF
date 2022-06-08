//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models.education;

namespace WebApplication3.Models
{
    public class SchoolSystem2 : DbContext
    {
        public SchoolSystem2() : base()
        {
        }
        public SchoolSystem2(DbContextOptions<SchoolSystem2> options)
               : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StudentInformation> StudentInformations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EducationalForm> EducationalForms {get;set; }
        public DbSet<EducationalQualification> EducationalQualifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TeacherCourse>().HasKey(c => new { c.TeacherId, c.CourseId });
            modelBuilder.Entity<StudentCourse>().HasKey(c => new { c.CourseId, c.StudentId });

        }

    }
}

