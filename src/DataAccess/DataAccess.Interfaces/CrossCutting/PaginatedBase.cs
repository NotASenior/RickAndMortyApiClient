namespace DataAccess.Interfaces.CrossCutting
{
    public class PaginatedBase
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public int Next { get; set; }
        public int Prev { get; set; }
    }
}
