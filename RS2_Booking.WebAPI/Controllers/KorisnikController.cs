using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Models;
using RS2_Booking.WebAPI.Services;

namespace RS2_Booking.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _korisnikService;

        public KorisnikController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }

        [HttpGet("{id}")]
        public KorisnikModel GetById(int id)
        {
           return _korisnikService.GetById(id);         
        }

        [HttpGet("/edit/{id}")]
        public KorisnikEditRequest EditById(int id)
        {
            return _korisnikService.GetKorisnikEdit(id);
        }


        [HttpGet]
        public List<KorisnikModel> Get([FromQuery]KorisnikSearchRequest search)
        {
            return _korisnikService.Get(search);
        }

        [HttpGet]
        [Route("GetIzdavaci")]
        public List<KorisnikModel> GetIzdavaci([FromQuery]KorisnikSearchRequest search )
        {
            return _korisnikService.GetIzdavaci(search);
        }

        [HttpPost]
        public KorisnikInsertRequest Insert(KorisnikInsertRequest Model)
        {
            return _korisnikService.Insert(Model);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _korisnikService.Delete(id);
        }

        [HttpPut("{id}")]
        public KorisnikModel Update(KorisnikModel Model, int id)
        {
            return _korisnikService.Update(Model, id);
        }
    }
}
