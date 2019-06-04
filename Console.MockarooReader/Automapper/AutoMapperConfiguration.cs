using AutoMapper;
using ConsoleApp.MockarooReader;
using Core.Models;

namespace ConsoleApp.MockarooReader
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JsonPost, Post>();
                cfg.CreateMap<JsonComment, Comment>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}