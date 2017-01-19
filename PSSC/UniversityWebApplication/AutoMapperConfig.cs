using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace UniversityWebApplication
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration MapperConfiguration;

        public static void RegisterMappings()
        {
           // MapperConfiguration = new MapperConfiguration(cfg => {
             //   cfg.CreateMap<Source, Dest>().ReverseMap();
            //});
        }
    }
}