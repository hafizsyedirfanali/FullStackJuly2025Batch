using MSIdentity.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Data.Entities
{
    public class Magazine
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public String Name { get; set; }
        public String? Description { get; set; }
        public Boolean IsActive { get; set; }
        public Category Category { get; set; }//Navigation property
        public int CategoryId { get; set; }

    }
}
