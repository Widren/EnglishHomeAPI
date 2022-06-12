using AutoMapper;
using EnglishHomeAPI.Domain.Models;
using EnglishHomeAPI.Resources;

namespace EnglishHomeAPI.Mapping
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
