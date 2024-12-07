﻿using Clinic.Core.Entities;
using Clinic.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private IDoctorService _service;
        public DoctorController(IDoctorService service)
        {
            _service = service;
            
        }
        // GET: api/<Doctor>
        [HttpGet]
        public IEnumerable<DoctorClass> Get()
        {
            return _service.GetDoctor();
        }

        // GET api/<Doctor>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Doctor>
        [HttpPost]
        public DoctorClass Post([FromBody] DoctorClass value)
        {
            _service.AddDoctor(value);
            return value;
        }

        // PUT api/<Doctor>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorClass value)
        {
            var index= _service.GetDoctor().FindIndex(e=>e.Id==id);
            _service.GetDoctor()[index] = value;
        }

        // DELETE api/<Doctor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _service.GetDoctor().FindIndex(e => e.Id == id);
            _service.GetDoctor().RemoveAt(index);
        }
    }
}
