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
    public class SmjestajController : ControllerBase
    {
        private readonly ISmjestajService _smjestajService;

        public SmjestajController(ISmjestajService smjestajService)
        {
            _smjestajService = smjestajService;
        }

        [HttpGet]
        public List<SmjestajModel> Get([FromQuery]SmjestajSearchRequest request)
        {
            var list = _smjestajService.Get(request);
            return list;
        }

        [HttpGet("{id}")]
        public SmjestajModel GetById(int id)
        {
            return _smjestajService.GetById(id);
        }
        
        [HttpPut("{id}")]
        public SmjestajModel Update(int id, SmjestajModel m)
        {
            return _smjestajService.Update(id, m);
        }
        [HttpPost]
        public void Insert(SmjestajInsertRequest request)
        {
            _smjestajService.Insert(request);
        }
    }
}
