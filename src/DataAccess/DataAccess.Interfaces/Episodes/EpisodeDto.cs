using DataAccess.Interfaces.CrossCutting;
using System.Runtime.Serialization;

namespace DataAccess.Interfaces.Episodes
{
    [DataContract]
    public class EpisodeDto : ModelBase
    {
        public string? Name { get; set; }

        [DataMember(Name = "air_date")]
        public string? AirDate { get; set; }

        [DataMember(Name = "Episode")]
        public string? Code { get; set; }
        public IEnumerable<string?>? Characters { get; set; }
    }
}
