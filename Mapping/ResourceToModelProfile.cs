using AutoMapper;
using BaseAPI.Controllers.Resources;
using BaseAPI.Core.Models;
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
            CreateMap<SaveSiparisResource, Siparis>();
            CreateMap<UserCredentialsResource, User>();
        }
    }
}