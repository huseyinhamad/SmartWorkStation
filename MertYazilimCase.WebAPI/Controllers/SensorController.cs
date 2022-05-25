using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;
using MertYazilimCase.Data.Models;
using Microsoft.AspNetCore.Mvc;
using MertYazilimCase.Data.DataLayer;
using MertYazilimCase.Business;

namespace MertYazilimCase.WebAPI.Controllers
{
    [Route("api/sensor")]
    public class SensorController : ControllerBase
    {
        private GenericRepository<Sensor> sensorRepository;
        public SensorController()
        {
            DatabaseContext context = new DatabaseContext();
            sensorRepository = new GenericRepository<Sensor>(context);
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody]Sensor sensor)
        {
            try
            {
                sensorRepository.Insert(sensor);
                sensorRepository.Save();
            }
            catch
            {
            }
            return Ok();
        }
    }
}
