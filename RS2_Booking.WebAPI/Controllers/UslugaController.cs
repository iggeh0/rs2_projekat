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
    public class UslugaController : ControllerBase
    {
        private readonly IUslugaService _Service;

        public UslugaController(IUslugaService okolinaService)
        {
            _Service = okolinaService;
        }
        [HttpGet]
        public List<UslugaModel> Get([FromQuery]UslugaSearchRequest search)
        {
            return _Service.Get(search);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Service.Delete(id);
        }


        [HttpPost]
        public virtual UslugaInsertRequest Insert(UslugaInsertRequest Model)
        {
            return _Service.Insert(Model);
        }

    }
}
