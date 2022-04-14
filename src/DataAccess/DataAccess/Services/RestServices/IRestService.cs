using DataAccess.CrossCutting.Api;

namespace DataAccess.Services.RestServices
{
    public interface IRestService<T>
    {
        Task<T> GetAsync(string endpoint, string method, int id);
        Task<ApiResponse<T>> GetAllAsync(string endpoint, string method, int page);
    }
}
