namespace DataAccess.Interfaces.CrossCutting
{
    public class Paginated<T> : PaginatedBase
    {
        public IEnumerable<T>? Results { get; set; }
    }
}
