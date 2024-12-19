using AutoMapper;
using Clinic.Core.Entities;
using Clinic.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly IRoutesService _routesService;
        private readonly IMapper _mapper;

        public RoutesController(IRoutesService routesService, IMapper mapper)
        {
            _routesService = routesService;
            _mapper = mapper;

        }
        // GET: api/<Routes>
        [HttpGet]
        public IEnumerable<RoutesClass> Get()
        {
            return _routesService.GetRoutes();
        }

        // GET api/<Routes>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Routes>
        [HttpPost]
        public RoutesClass Post([FromBody] RoutesClass value)
        {
            _routesService.AddRoutes(value);
            return value;
        }

        // PUT api/<Routes>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoutesClass value)
        {
            var index = _routesService.GetRoutes().ToList().FindIndex(e => e.IdRoutes == id);
            _routesService.GetRoutes().ToList()[index] = value;
        }

        // DELETE api/<Routes>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = _routesService.GetRoutes().ToList().FindIndex(e => e.IdRoutes== id);
            _routesService.GetRoutes().ToList().RemoveAt(index);
        }
    }
}
