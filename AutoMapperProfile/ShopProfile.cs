using AutoMapper;
using SimpleWebApi.Entity;
using SimpleWebApi.Models;

namespace SimpleWebApi2.AutoMapperProfile
{
    public class ShopProfile : Profile
    {
       public ShopProfile()
       {
           CreateMap<Shop,SeachShopDetailViewModel>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.shopName, opt => opt.MapFrom(src => src.shopName))
           .ForMember(dest => dest.shopImgUrl, opt => opt.MapFrom(src => src.shopImgUrl))
           .ForMember(dest => dest.shopSrc, opt => opt.MapFrom(src => src.shopSrc))
           .ForMember(dest => dest.rebeat, opt => opt.MapFrom(src => src.rebeat));
       }
       
    }
    public class CouponProfile : Profile
    {
       public CouponProfile()
       {
           CreateMap<Coupon,GetCouponStatusDetailViewModel>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           .ForMember(dest => dest.shopName, opt => opt.MapFrom(src => src.shopName))
           .ForMember(dest => dest.shopImgUrl, opt => opt.MapFrom(src => src.shopImgUrl))
           .ForMember(dest => dest.status, opt => opt.MapFrom(src => src.status))
           .ForMember(dest => dest.rebeat, opt => opt.MapFrom(src => src.rebeat));
       }
    }
}