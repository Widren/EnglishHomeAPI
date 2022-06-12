using AutoMapper;
using BaseAPI.Domain.Models;
using BaseAPI.Resources;

namespace BaseAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>();
        }
    }
}
