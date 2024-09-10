namespace Data.DTO
{
    public class SubjectDTO
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfCredits { get; set; }
        public int SemesterNumber { get; set; }
        public string StudyTime { get; set; }
        public string? Note { get; set; }
    }
}