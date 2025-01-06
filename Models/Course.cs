namespace _1_Asp.Net_MVC.Models;

    public class Course
    {
        public int Id  { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Desc { get; set; }
        public string[]? Tags { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
    }
