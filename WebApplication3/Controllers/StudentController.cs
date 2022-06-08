using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication3.Services;
using WebApplication3.Models;
using System.Collections.Generic;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private StudentService service;
        public StudentController(StudentService service)
        {
            this.service = service;

        }
        public StudentService Service { get; }
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await service.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<Student> GetById(int id)
        {
            return  await service.GetById(id);
        }
        [HttpPost]
        public async Task Post([FromBody] Student obj)
        {
            await service.Post(obj);
        }
        [HttpPut]
        public async Task<Student> Put(Student obj)
        {
            return await service.Put(obj);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Delete(id);
        }
    }
}