using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        [Route("GetFullSmjestaj")]
        public SmjestajModelFull GetFullSmjestaj([FromQuery]SmjestajSearchRequest request)
        {
            return _smjestajService.GetFullSmjestaj(request.SmjestajId);
        }

        [HttpPost]
        public SmjestajInsertRequest Insert(SmjestajInsertRequest Model)
        {
            return _smjestajService.Insert(Model);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _smjestajService.Delete(id);
        }

        [HttpPut("{id}")]
        public SmjestajModel Update(SmjestajModel Model)
        {
            return _smjestajService.Update(Model);
        }

        [HttpGet]
        public List<SmjestajModel> Get([FromQuery]SmjestajSearchRequest search)
        {
            return _smjestajService.Get(search);
        }
    }
}
