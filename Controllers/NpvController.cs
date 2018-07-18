using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using npvWebAPI.Models;
using npvWebAPI.Services;

namespace npvWebAPI.Controllers
{
    [Route("api/npv/[action]")]
    [ApiController]
    public class NpvController : ControllerBase
    {
        private NpvService service;

        public NpvController()
        { 
            this.service = new NpvService();
        }

        [HttpPost]
        [ActionName("getChartData")]

        public IActionResult GetChartdata(NpvRequest item)
        {
            var result = this.service.GetChartData(item);
            return Ok(result);
        }

        [HttpPost]
        [ActionName("getNpv")]
        public IActionResult GetNpv(NpvChartRequest item)
        {
            var result = this.service.GetNpv(item);
            return Ok(result);
        }
    }
}