using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RS2_Booking.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OkolinaController : ControllerBase
    {
        private readonly IOkolinaService _Service;

        public OkolinaController(IOkolinaService okolinaService)
        {
            _Service = okolinaService;
        }
        [HttpGet]
        public List<OkolinaModel> Get([FromQuery]OkolinaSearchRequest search)
        {
            return _Service.Get(search);
        }

        [Authorize(Roles ="Izdavac")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Service.Delete(id);
        }

        [Authorize(Roles = "Izdavac")]
        [HttpPost]
        public virtual OkolinaInsertRequest Insert(OkolinaInsertRequest Model)
        {
            return _Service.Insert(Model);
        }

    }
}
