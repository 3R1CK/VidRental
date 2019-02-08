using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VidRental.Models;
using VidRental.Dtos;

namespace VidRental.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()

        {
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<Customer, CustomerDto>();
                
            Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<Movie, MovieDto>();

            Mapper.CreateMap<MovieDto, Movie>();
        }
    }
}