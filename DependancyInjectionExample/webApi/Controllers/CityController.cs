using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
     
        private readonly ICitiesService _cityService1;

        private readonly ICitiesService _cityService2;

        private readonly ICitiesService _cityService3;


        public CitiesController(ICitiesService cityService1, ICitiesService cityService2, ICitiesService cityService3) {

          
            _cityService1 = cityService1;
            _cityService2 = cityService2;
            _cityService3 = cityService3;


        }



        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            var result = new { service1 = _cityService1.ServiceInstanceId(), service2 = _cityService2.ServiceInstanceId(), service3 = _cityService3.ServiceInstanceId(), cities = _cityService1.GetCities() };

            return StatusCode(203, result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

