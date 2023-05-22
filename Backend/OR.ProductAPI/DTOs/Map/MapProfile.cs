using AutoMapper;
using OR.ProductAPI.Models;

namespace OR.ProductAPI.DTOs.Map;
public class MapProfile : Profile {
    public MapProfile() {
        CreateMap<CategoryModel, CategoryDTO>().ReverseMap();
        CreateMap<ProductModel, ProductDTO>().ReverseMap();

    }
}
