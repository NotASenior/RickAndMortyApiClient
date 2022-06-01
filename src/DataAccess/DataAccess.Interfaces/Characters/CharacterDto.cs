using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.Interfaces.Characters
{
    public class CharacterDto : ModelBase
    {
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Species { get; set; }
        public string? Type { get; set; }
        public string? Gender { get; set; }
        public NameUrlModel? Origin { get; set; }
        public NameUrlModel? Location { get; set; }
        public string? Image { get; set; }
        public IEnumerable<string>? Episode { get; set; }
    }
}
