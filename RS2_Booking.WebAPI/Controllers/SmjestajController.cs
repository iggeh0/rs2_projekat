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
    public class SmjestajController : BaseController<SmjestajModel, SmjestajSearchRequest>
    {
        public SmjestajController(IService<SmjestajModel, SmjestajSearchRequest> Service) : base(Service)
        {
        }

        
        //[HttpPut("{id}")]
        //public SmjestajModel Update(int id, SmjestajModel m)
        //{
        //    return _smjestajService.Update(id, m);
        //}
        //[HttpPost]
        //public void Insert(SmjestajInsertRequest request)
        //{
        //    _smjestajService.Insert(request);
        //}
    }
}
