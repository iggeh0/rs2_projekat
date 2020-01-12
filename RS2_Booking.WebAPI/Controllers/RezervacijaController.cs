using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Services;

namespace RS2_Booking.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijaController : ControllerBase
    {
        private IRezervacijaService _service;

        public RezervacijaController(IRezervacijaService Service)
        {
            _service = Service;
        }

        [HttpGet]
        public List<RezervacijaModel> Get([FromQuery]RezervacijaSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

        [HttpGet("{id}")]
        public RezervacijaModel GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public virtual RezervacijaInsertRequest Insert(RezervacijaInsertRequest Model)
        {
            return _service.Insert(Model);
        }

        //[HttpPut("{id}")]
        //public TModel Update(TModel Model, int id)
        //{
        //    return _Service.Update(Model, id);
        //}
    }
}