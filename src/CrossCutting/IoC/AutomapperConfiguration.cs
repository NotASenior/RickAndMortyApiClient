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
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CharacterDto, Character>()
                .ForMember(nameof(Character.Episodes), to => to.MapFrom(nameof(CharacterDto.Episode)));
                cfg.CreateMap<NameUrlModel, NameUrl>();
                cfg.CreateMap(typeof(Paginated<>), typeof(Paginated<>));
                cfg.CreateMap(typeof(ApiResponse<>), typeof(Paginated<>))
                    .ForMember("Count", to => to.MapFrom("Info.Count"))
                    .ForMember("Pages", to => to.MapFrom("Info.Pages"));
                ;
            });
            
            return config.CreateMapper();
        }
    }
}