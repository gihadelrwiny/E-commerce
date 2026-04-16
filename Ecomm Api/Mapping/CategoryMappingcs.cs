using AutoMapper;
using EcommCore.DTO;
using EcommCore.Entites.product;

namespace Ecomm_Api.Mapping
{
    public class CategoryMappingcs:Profile
    {
        public CategoryMappingcs()
        {
            CreateMap<CategoryDTO,Category>().ReverseMap();
            CreateMap<UpdateCategoryDTO, Category>().ReverseMap();
        }
    }
}
