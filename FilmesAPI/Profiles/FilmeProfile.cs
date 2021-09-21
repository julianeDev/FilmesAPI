using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDTO, Filme>();
            CreateMap<ReadFilmeDTO, Filme>();
            CreateMap<UpdateFilmeDTO, Filme>();
        }
    }
}
