using API.DTOS;
using AutoMapper;
using Core.Models;
using OMDBAPI.Integration.Models;

namespace API.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PostDTO, Post>();
                cfg.CreateMap<Post, PostDTO>();
                cfg.CreateMap<CommentDTO, Comment>();
                cfg.CreateMap<Comment, CommentDTO>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}