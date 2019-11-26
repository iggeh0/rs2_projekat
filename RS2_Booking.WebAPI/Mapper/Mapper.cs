using AutoMapper;
using RS2_Booking.Model.Requests;
using RS2_Booking.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Booking.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Korisnik, Model.KorisnikModel>();
            CreateMap<Model.KorisnikModel, Korisnik>();
            CreateMap<KorisnikInsertRequest, Korisnik>()
            .ForMember(dest => dest.Klijent, opt => opt.Ignore())
            .ForMember(dest => dest.Izdavac, opt => opt.Ignore());
            CreateMap<Korisnik, KorisnikEditRequest>();
            CreateMap<KorisnikEditRequest, Korisnik>();
            CreateMap<SmjestajInsertRequest, Smjestaj>();
            CreateMap<Smjestaj, Model.SmjestajModel>();
            CreateMap<Model.SmjestajModel,Smjestaj>();
            CreateMap<Grad, Model.GradModel>();
            CreateMap<Soba, Model.SobaModel>();
            CreateMap<Model.SobaModel, Soba>();
            CreateMap<SobaInsertRequest, Soba>();
            CreateMap<Soba, SobaInsertRequest>();
            CreateMap<Model.InventarModel, Inventar>();
            CreateMap<Inventar, Model.InventarModel>();
            CreateMap<Model.OkolinaModel, Okolina>();
            CreateMap<Okolina, Model.OkolinaModel>();
            CreateMap<Okolina, OkolinaInsertRequest>();
            CreateMap<OkolinaInsertRequest, Okolina>();
            CreateMap<Usluga, UslugaInsertRequest>();
            CreateMap<UslugaInsertRequest, Usluga>();
        }
    }
}
