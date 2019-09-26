using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RS2_Booking.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel, TSearch> : ControllerBase
    {

        private IService<TModel, TSearch> _Service;

        public BaseController(IService<TModel, TSearch> Service)
        {
            _Service = Service;
        }

        [HttpGet]
        public List<TModel> Get([FromQuery]TSearch search)
        {
            return _Service.Get(search);
        }

        [HttpGet("{id}")]
        public TModel GetById(int id)
        {
            return _Service.GetById(id);
        }
    }
}
