using DataAccess.Services.RestServices.Models;
using System.Runtime.Serialization;

namespace DataAccess.Services.RestService.Models
{
    [DataContract]
    public class EpisodeModel : ModelBase
    {
        internal string? Name { get; set; }

        [DataMember(Name = "air_date")]
        internal string? AirDate { get; set; }

        [DataMember(Name = "Episode")]
        internal string? Code { get; set; }
        internal IEnumerable<string?>? Characters { get; set; }
    }
}
