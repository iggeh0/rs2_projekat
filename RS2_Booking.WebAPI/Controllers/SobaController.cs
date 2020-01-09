using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RS2_Booking.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SobaController : ControllerBase
    {
        private ISobaService _sobaService;
        public SobaController(ISobaService sobaService)
        {
            _sobaService = sobaService;
        }

        [HttpGet]
        public List<SobaModel> Get([FromQuery]SobaSearchRequest search)
        {
            return _sobaService.Get(search);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _sobaService.Delete(id);
        }

        [HttpGet("{id}")]
        public SobaModel GetById(int id)
        {
            return _sobaService.GetById(id);
        }

        [HttpPost]
        public virtual SobaInsertRequest Insert(SobaInsertRequest Model)
        {
            return _sobaService.Insert(Model);
        }

        [HttpPut("{id}")]
        public SobaModel Update(SobaModel Model, int id)
        {
            return _sobaService.Update(Model, id);
        }

 
    }
}
