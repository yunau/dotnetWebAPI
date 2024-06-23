namespace SIMPLEWEBAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
    }
}