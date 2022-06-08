using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Teacher
    {
        public int Id { get; set; }


        public string Firstname { get; set; }


        public string Middlename { get; set; }


        public string Lastname { get; set; }

        public int Age { get; set; }

        public bool IsActive { get; set; } = true;

    }
}