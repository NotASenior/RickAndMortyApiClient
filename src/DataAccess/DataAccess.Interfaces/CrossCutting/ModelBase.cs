namespace DataAccess.Interfaces.CrossCutting
{
    public class ModelBase
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public DateTime Created { get; set; }
    }
}
