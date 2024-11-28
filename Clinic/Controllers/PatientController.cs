using Clinic.Core.Entities;
using Clinic.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatientService _patientService;


        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        // GET: api/<patient>
        [HttpGet]
        public IEnumerable<PatientClass> Get()
        {
            return _patientService.GetPatient();
        }

        // GET api/<patient>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<patient>
        [HttpPost]
        public PatientClass Post([FromBody] PatientClass value)
        {
            _patientService.AddPtient(value);
            return value;
        }

        // PUT api/<patient>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PatientClass value)
        {
            var index = _patientService.GetPatient().FindIndex(e => e.Id == id);
            _patientService.GetPatient()[index] = value;
        }

        // DELETE api/<patient>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _patientService.GetPatient().FindIndex(e => e.Id == id);
            _patientService.GetPatient().RemoveAt(index);
        }
    }
}
