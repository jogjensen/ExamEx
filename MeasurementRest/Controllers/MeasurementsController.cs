using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnviromentModelLib.model;
using MeasurementRest.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeasurementRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {

        private static MeasurementManager mgr = new MeasurementManager();


        // GET: api/<MeasurementsController>
        [HttpGet]
        public IEnumerable<Measurement> Get()
        {
            return mgr.GetAll();
        }

        // GET api/<MeasurementsController>/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        //Implementere Iactionresult så vi kan få status koder tilbage (200 hvis det er gået godt , 404 hvis det er gået dårligt)
        {
            try
            {
                return Ok(mgr.GetById(id));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // POST api/<MeasurementsController>
        [HttpPost]
        public void Post([FromBody] Measurement value)
        {
            mgr.Add(value);
        }

        // DELETE api/<MeasurementsController>/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(mgr.DeleteById(id));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }

        }
    }
}
