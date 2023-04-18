﻿using AutoMapper;
using Quiron.Service.AutoMapper;

namespace Quiron.NUnitTest.Utilitarios
{
    public class Mapeador
    {
        public static IMapper GetMapper()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapping()));
            return mapperConfiguration.CreateMapper();
        }
    }
}