namespace DataAccess.Services.RestServices.Models
{
    public class ModelBase
    {
        internal int Id { get; set; }
        internal string? Url { get; set; }
        internal DateTime Created { get; set; }
    }
}
