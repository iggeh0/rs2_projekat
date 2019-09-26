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
        public ActionResult<List<Model.KorisnikModel>> Get()
        {
            return _korisnikService.Get();
        }


        [HttpPost]
        public void Insert(KorisnikInsertRequest request)
        {
           _korisnikService.Insert(request);
        }
    }
}
