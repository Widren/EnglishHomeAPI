using AutoMapper;
using BaseAPI.Domain.Models;
using BaseAPI.Resources;

namespace BaseAPI.Mapping
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