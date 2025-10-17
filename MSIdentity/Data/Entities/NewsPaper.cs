using MSIdentity.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace MSIdentity.Data.Entities
{
    public class NewsPaper
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public Boolean IsActive { get; set; }
        public Category? Category { get; set; }//Navigation property
        public int CategoryId { get; set; }
    }
}
