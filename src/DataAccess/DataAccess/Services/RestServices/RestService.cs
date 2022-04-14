using DataAccess.CrossCutting.Api;
using RestSharp;
using Serilog;

namespace DataAccess.Services.RestServices
{
    public class RestService<T> : IRestService<T>
    {
        public async Task<T> GetAsync(string endpoint, string method, int id)
        {
            var client = new RestClient(endpoint);
            var request = new RestRequest($"{method}/{id}");

            try
            {
                var response = await client.ExecuteGetAsync<T>(request);

                return response.Data;
            }
            catch (Exception ex)
            {
                Log.Error(ex, nameof(RestService<T>));
                throw;
            }
        }

        public async Task<ApiResponse<T>> GetAllAsync(string endpoint, string method, int page)
        {
            var client = new RestClient(endpoint);
            var request = new RestRequest(method);

            try
            {
                var response = await client.ExecuteGetAsync<ApiResponse<T>>(request);

                return response.Data ?? ApiResponse<T>.Null<T>();
            }
            catch (Exception ex)
            {
                Log.Error(ex, nameof(RestService<T>));
                throw;
            }
        }
    }
}
