﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RS2_Booking.WebAPI.Controllers
{
    public class UslugaController : BaseController<UslugaModel, UslugaSearchRequest, UslugaInsertRequest>
    {
        public UslugaController(IService<UslugaModel, UslugaSearchRequest, UslugaInsertRequest> Service) : base(Service)
        {
        }
    }
}
