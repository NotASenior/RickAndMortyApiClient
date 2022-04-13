namespace Entities.CrossCutting
{
    public class EntityBase
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public DateTime Created { get; set; }
    }
}