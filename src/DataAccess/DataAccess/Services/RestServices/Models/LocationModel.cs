using DataAccess.Services.RestServices.Models;

namespace DataAccess.Services.RestService.Models
{
    public class LocationModel : ModelBase
    {
        internal string? Name { get; set; }
        internal string? Type { get; set; }
        internal string? Dimension { get; set; }
        internal IEnumerable<string?>? Residents { get; set; }
    }
}
