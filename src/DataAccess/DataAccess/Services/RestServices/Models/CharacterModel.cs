using DataAccess.Services.RestServices.Models;
using Entities.CrossCutting;

namespace DataAccess.Services.RestService.Models
{
    public class CharacterModel : ModelBase
    {
        internal string? Name { get; set; }
        internal string? Status { get; set; }
        internal string? Species { get; set; }
        internal string? Type { get; set; }
        internal string? Gender { get; set; }
        internal NameUrl? Origin { get; set; }
        internal NameUrl? Location { get; set; }
        internal string? Image { get; set; }
        internal IEnumerable<string?>? Episode { get; set; }
    }
}
