namespace Data.DTO
{
    public class ResponeModel<T>
    {
        public string? CampusId { get; set; }
        public string? Search { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 1;
        public int PageSize { get; set; } = 8;
        public int TotalItems { get; set; } = 0;
        public List<T>? Item { get; set; }
    }
}
