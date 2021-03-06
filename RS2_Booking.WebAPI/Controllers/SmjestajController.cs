﻿using System;
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

        [HttpPost]
        [Route("InsertImage")]
        public SlikaModel InsertImage(SlikaModel Model)
        {
            return _smjestajService.InsertImage(Model);
        }

        [HttpGet]
        [Route("GetImages")]
        public List<SlikaModel> GetImages([FromQuery]SlikaGetRequest request)
        {
            return _smjestajService.GetImages(request.SmjestajId);
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
        [HttpGet("{id}")]
        public SmjestajModel GetById(int id)
        {
            return _smjestajService.GetById(id);
        }

        [HttpGet]
        [Route("GetIzvjestaj")]
        public IzvjestajModel GetIzvjestaj(int id)
        {
            return _smjestajService.GetIzvjestaj(id);
        }

        [HttpPost]
        [Route("OcjeniSmjestaj")]
        public OcjeniSmjestajRequest OcjeniSmjestaj(OcjeniSmjestajRequest request)
        {
            return _smjestajService.Ocjeni(request);
        }
    }
}
