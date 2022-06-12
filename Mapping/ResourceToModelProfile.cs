using AutoMapper;
using EnglishHomeAPI.Domain.Models;
using EnglishHomeAPI.Resources;

namespace EnglishHomeAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
            CreateMap<SaveProductResource, Product>();
        }
    }
}