using AutoMapper;
using Clinic.Core.Entities;
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
        private readonly IDoctorService _service;
        private readonly IMapper _mapper;
        public DoctorController(IDoctorService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
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
            var index= _service.GetDoctor().ToList().FindIndex(e=>e.Id==id);
            _service.GetDoctor().ToList()[index] = value;
        }

        // DELETE api/<Doctor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _service.GetDoctor().ToList().FindIndex(e => e.Id == id);
            _service.GetDoctor().ToList().RemoveAt(index);
        }
    }
}
