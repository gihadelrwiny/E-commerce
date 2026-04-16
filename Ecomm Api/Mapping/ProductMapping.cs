using AutoMapper;
using EcommCore.DTO;
using EcommCore.Entites.product;

namespace Ecomm_Api.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product,ProductDTO>().ForMember(X=>X.CategoryName, opt => opt.MapFrom(src => src.Category.Name)).ReverseMap();
             CreateMap<PhotoDTO, Photo>().ReverseMap();
        }
    }
}
