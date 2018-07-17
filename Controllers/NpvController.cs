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
        public NpvController()
        { }

        [HttpPost]
        [ActionName("getChartData")]

        public IActionResult GetChartdata(NpvRequest item)
        {
            var result = new NpvService();
            var x = result.GetChartData(item);
            return Ok(x);
        }

        [HttpPost]
        [ActionName("getNpv")]
        public IActionResult GetNpv(NpvChartRequest item)
        {
            var result = new NpvService();
            var x = result.GetNpv(item);
            return Ok(x);
        }
    }
}