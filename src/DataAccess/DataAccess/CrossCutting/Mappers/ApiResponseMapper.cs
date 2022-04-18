using AutoMapper;
using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Utils;
using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.CrossCutting.Mappers
{
    public class ApiResponseMapper : IApiResponseMapper
    {
        private readonly IMapper mapper;

        public ApiResponseMapper(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Paginated<T> Map<T>(ApiResponse<T> objectToMap)
        {
            Paginated<T> entities = mapper.Map<Paginated<T>>(objectToMap);

            entities.Prev = objectToMap?.Info?.Prev.ToPageNumber() ?? 0;
            entities.Next = objectToMap?.Info?.Next.ToPageNumber() ?? 0;

            return entities;
        }
    }
}
