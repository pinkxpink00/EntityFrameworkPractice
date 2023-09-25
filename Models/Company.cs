namespace EFPractice.Models
{
    public class Company
    {
        public string? Name { get; set; }
        public int Id { get; set; }

        public List<User> Users { get; set; } = new();
    }
}
