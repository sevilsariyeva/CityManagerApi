using AutoMapper;
using CityManagerApi.Dtos;
using CityManagerApi.Models;

namespace CityManagerApi.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(dest => dest.PhotoUrl, option =>
                {
                    option.MapFrom(src => src.CityImages.FirstOrDefault(p => p.IsMain==true).Url);
                });

            CreateMap<CityDto, City>().ReverseMap();
            CreateMap<City, CityForDetailDto>().ReverseMap();
        }
    }
}
