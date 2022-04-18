using DataAccess.CrossCutting.Api;
using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.CrossCutting.Mappers
{
    public interface IApiResponseMapper
    {
        Paginated<T> Map<T>(ApiResponse<T> objectToMap);
    }
}
