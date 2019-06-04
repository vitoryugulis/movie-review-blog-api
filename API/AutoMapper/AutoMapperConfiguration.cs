using API.DTOS;
using AutoMapper;
using Core.Models;

namespace API.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PostDTO, Post>();
                cfg.CreateMap<CommentDTO, Comment>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}