namespace DataAccess.CrossCutting.Api
{
    public class ApiResponse<T>
    {
        public InfoDto? Info { get; set; }
        public IEnumerable<T?>? Results { get; set; }

        public static ApiResponse<T2> Null<T2>()
        {
            return new ApiResponse<T2>
            {
                Info = new InfoDto(),
                Results = new List<T2?>()
            };
        }
    }
}
