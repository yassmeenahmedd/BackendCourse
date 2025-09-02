using AutoMapper;
using mango.Services.CouponAPI.Models;
using mango.Services.CouponAPI.Models.DTO;

namespace mango.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {

                config.CreateMap<Coupon, CouponDTO>();
                config.CreateMap<CouponDTO, Coupon>();
            });
           
            return mappingConfig;
        }
    }
}