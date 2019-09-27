using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.WebAPI.Services;

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

        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            _Service.Remove(id);
        }

        [HttpGet("{id}")]
        public TModel GetById(int id)
        {
            return _Service.GetById(id);
        }

        [HttpPost]
        public virtual TModel Insert(TModel Model)
        {
            return _Service.Insert(Model);
        }

        [HttpPut("{id}")]
        public TModel Update(TModel Model, int id)
        {
            return _Service.Update(Model, id);
        }
    }
}
