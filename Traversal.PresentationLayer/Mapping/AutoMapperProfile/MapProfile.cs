using AutoMapper;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;
using Traversal.DTOLayer.DTOs.AppUserDTOs;
using Traversal.DTOLayer.DTOs.CityDTOs;
using Traversal.EntityLayer.Concrate;

namespace Traversal.PresentationLayer.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTO, Announcement>().ReverseMap();

            CreateMap<AppUserRegisterDTO, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDTO, AppUser>().ReverseMap();

            CreateMap<AnnouncementListDTO, Announcement>().ReverseMap();

            CreateMap<AnnouncementUpdateDTO, Announcement>().ReverseMap();
        }
    }
}
