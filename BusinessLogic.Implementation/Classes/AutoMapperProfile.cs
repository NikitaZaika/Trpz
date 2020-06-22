using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Models;

namespace BusinessLogic.Implementation.Classes
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<OrderEntity, Order>().ReverseMap();
            CreateMap<CookEntity, Cook>().ReverseMap();
            CreateMap<ClientEntity, Client>().ReverseMap();
            CreateMap<DishEntity, Dish>().ReverseMap();
        }
    }
}
