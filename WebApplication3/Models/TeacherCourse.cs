using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class TeacherCourse
    {
  
        public int TeacherId { get; set; }

        public int CourseId { get; set; }
    }
}