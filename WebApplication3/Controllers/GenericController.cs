﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication3.Models.education;
using WebApplication3.Services;
namespace WebApplication3.Controllers
{
    public class GenericController<T> : ControllerBase where T :  Education 
    {
        private readonly GenericService<T> service;
  
        public GenericController(GenericService<T> service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<IEnumerable<T>> Get()
        {
            return await service.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await service.GetById(id);
        }
        [HttpPost]
        public async Task Post(T obj)
        {
            await service.Post(obj);
        }
        [HttpPut]
        public async Task Put(T obj)
        {
            await service.Put(obj);
        }
        [HttpDelete("{id}")]
        public async Task  Delete(int id)
        {
            await service.Delete(id);
        }
    }
}