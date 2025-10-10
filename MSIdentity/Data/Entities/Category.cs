using System.ComponentModel.DataAnnotations;

namespace MSIdentity.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
