using Entities.CrossCutting;

namespace Entities.Episodes
{
    public class Episode : EntityBase
    {
        public string? Name { get; set; }
        public string? AirDate { get; set; }
        public string? Code { get; set; }
        public IEnumerable<string?>? Characters { get; set; }
    }
}
