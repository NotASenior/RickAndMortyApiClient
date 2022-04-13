using Entities.CrossCutting;

namespace Entities.Characters
{
    public class Character : EntityBase
    {
        public string? Name { get; set; }
        public CharacterStatus Status { get; set; }
        public string? Species { get; set; }
        public string? Type { get; set; }
        public Gender Gender { get; set; }
        public NameUrl? Origin { get; set; }
        public NameUrl? Location { get; set; }
        public string? Image { get; set; }
        public IEnumerable<string?>? Episodes { get; set; }
    }
}
