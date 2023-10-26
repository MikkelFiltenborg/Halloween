using System.ComponentModel.DataAnnotations;

namespace Halloween.API.DTO
{
    //Data Transffer Object
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? RealName { get; set; }
        public string? Place { get; set; }
        public DateTime DebutYear { get; set; }
    }
}
