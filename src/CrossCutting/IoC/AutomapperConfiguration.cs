using AutoMapper;
using DataAccess.CrossCutting.Api;
using DataAccess.Interfaces.Characters;
using DataAccess.Interfaces.CrossCutting;
using Entities.Characters;
using Entities.CrossCutting;

namespace IoC
{
    public abstract class AutomapperConfiguration
    {
        public static MapperConfiguration GetConfig()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CharacterDto, Character>()
                .ForMember(nameof(Character.Episodes), to => to.MapFrom(nameof(CharacterDto.Episode)));
                cfg.CreateMap<NameUrlModel, NameUrl>();
                cfg.CreateMap(typeof(Paginated<>), typeof(Paginated<>))
                    .ForMember("Prev", opt => opt.Ignore())
                    .ForMember("Next", opt => opt.Ignore());
                cfg.CreateMap(typeof(ApiResponse<>), typeof(Paginated<>))
                    .ForMember("Count", opt => opt.MapFrom("Info.Count"))
                    .ForMember("Pages", opt => opt.MapFrom("Info.Pages"))
                    .ForMember("Prev", opt => opt.Ignore())
                    .ForMember("Next", opt => opt.Ignore());
                ;
            });
        }

        public static IMapper GetMapper()
        {
            var config = GetConfig();
            return config.CreateMapper();
        }
    }
}