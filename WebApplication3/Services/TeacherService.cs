//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections;
////using System.Data.Entity;
//using System.Linq;
//using System.Threading.Tasks;
//using WebApplication3.Models;

//namespace WebApplication3.Services
//{
//    public class TeacherService
//    {
//        private readonly SchoolSystem db;
//        public TeacherService(SchoolSystem db)
//        {
//            this.db = db;
//        }
//        public async Task<IEnumerable> GetAll()
//        {
//            return await db.Teachers.ToListAsync();
//        }
//        public async Task<IEnumerable> GetById(int Id)
//        {
//            return (IEnumerable)await db.Teachers.SingleOrDefaultAsync(s => s.Id == Id);
//        }
//        public async Task Post(Teacher obj)
//        {
//            if (obj == null)
//            {
//                throw new Exception("obj is null");
//            }

//            db.Teachers.Add(obj);

//            await db.SaveChangesAsync();
//        }
//        public async Task<IEnumerable> Put(Teacher obj)
//        {
            
//        }
//    }
    
//}
