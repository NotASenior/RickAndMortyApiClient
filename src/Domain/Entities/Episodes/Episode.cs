using Entities.CrossCutting;
using System.Runtime.Serialization;

namespace Entities.Episodes
{
    [DataContract]
    public class Episode : EntityBase
    {
        public string? Name { get; set; }
        
        [DataMember(Name = "air_date")]
        public string? AirDate { get; set; }

        [DataMember(Name = "Episode")]
        public string? Code { get; set; }
        public IEnumerable<string?>? Characters { get; set; }
    }
}
