using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.Interfaces.Locations
{
    public class LocationDto : ModelBase
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Dimension { get; set; }
        public IEnumerable<string>? Residents { get; set; }
    }
}
