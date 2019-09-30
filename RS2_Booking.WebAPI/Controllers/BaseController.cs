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
    public class BaseController<TModel, TSearch, TInsertModel> : ControllerBase
    {

        private IService<TModel, TSearch, TInsertModel> _Service;

        public BaseController(IService<TModel, TSearch, TInsertModel> Service)
        {
            _Service = Service;
        }

        [HttpGet]
        public List<TModel> Get([FromQuery]TSearch search)
        {
            return _Service.Get(search);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Service.Delete(id);
        }

        [HttpGet("{id}")]
        public TModel GetById(int id)
        {
            return _Service.GetById(id);
        }

        [HttpPost]
        public virtual TInsertModel Insert(TInsertModel Model)
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
