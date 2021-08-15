using System;
using AutoMapper;
using filmesapi.Data.Dtos;
using filmesapi.Models;

namespace filmesapi.Profiles
{
    public class FilmeProfile : Profile    
    {
        public FilmeProfile() 
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }        
    }   
}