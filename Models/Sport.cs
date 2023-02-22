namespace StudentPortal.Models
{
    public class Sport
    {
        public int Id { get; set; } 
        public string? SportName { get; set; }

        public virtual List<Student>? Students { get; set; }

    }
}
