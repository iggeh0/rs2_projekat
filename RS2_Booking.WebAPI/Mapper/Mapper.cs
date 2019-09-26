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
            CreateMap<KorisnikInsertRequest, Korisnik>()
            .ForMember(dest => dest.Klijent, opt => opt.Ignore())
            .ForMember(dest => dest.SifraHash, opt => opt.Ignore())
            .ForMember(dest => dest.SifraSalt, opt => opt.Ignore())
            .ForMember(dest => dest.Izdavac, opt => opt.Ignore());
            CreateMap<Korisnik, KorisnikEditRequest>();
            CreateMap<SmjestajInsertRequest, Smjestaj>();
            CreateMap<Smjestaj, Model.SmjestajModel>();
            CreateMap<Grad, Model.GradModel>();
            CreateMap<Soba, Model.SobaModel>();
            CreateMap<Model.SobaModel, Soba>();
        }
    }
}
