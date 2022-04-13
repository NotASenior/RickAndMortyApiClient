using Entities.CrossCutting;

namespace Entities.Locations
{
    public class Location : EntityBase
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Dimension { get; set; }
        public IEnumerable<string?>? Residents { get; set; }
    }
}
