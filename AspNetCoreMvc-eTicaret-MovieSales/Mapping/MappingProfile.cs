﻿using AspNetCoreMvc_eTicaret_MovieSales.Models;
using AspNetCoreMvc_eTicaret_MovieSales.ViewModels;
using AutoMapper;

namespace AspNetCoreMvc_eTicaret_MovieSales.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Genre, GenreViewModel>().ReverseMap();

        }

    }
}