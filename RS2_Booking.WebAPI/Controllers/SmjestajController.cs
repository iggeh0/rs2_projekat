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
    [Authorize(Roles = "Izdavac, Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class SmjestajController : BaseController<SmjestajModel, SmjestajSearchRequest, SmjestajInsertRequest>
    {
        public SmjestajController(IService<SmjestajModel, SmjestajSearchRequest, SmjestajInsertRequest> Service) : base(Service)
        {
        }
        //[HttpGet]
        //[Route("GetGrad")]
        //public List<GradModel> Get()
        //{
        //    return new List<GradModel>();
        //}
    }
}
