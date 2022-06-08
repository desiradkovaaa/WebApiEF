//using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class StudentService
    {
        private readonly SchoolSystem2 db;

        public StudentService()
        {

        }

        public StudentService(SchoolSystem2 db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await db.Students.ToListAsync();
        }

        public async Task<Student> GetById(int Id)
        {
            return await db.Students.SingleOrDefaultAsync(s => s.Id == Id);
        }

        public async Task Post(Student obj)
        {
            if (obj == null)
            {
                throw new Exception("obj is null");
            }

            db.Students.Add(obj);

            await db.SaveChangesAsync();

        }

        public async Task<Student> Put(Student obj)
        {
            if (obj == null)
            {
                throw new Exception("Invalid data");
            }
            var existingStudent = await db.Students.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (existingStudent != null)
            {
                existingStudent.Firstname = obj.Firstname;
                existingStudent.Middlename = obj.Middlename;
                existingStudent.Lastname = obj.Lastname;
                existingStudent.Birthdate = obj.Birthdate;
                existingStudent.StudentCourses = obj.StudentCourses;
                await db.SaveChangesAsync();
            }

            return existingStudent;
        }

        public async Task Delete(int id)
        {

            var model = await db.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                throw new Exception("Invalid Data");
            }
         
            db.Students.Remove(model);
            await db.SaveChangesAsync();
        }
    }
}