using MSIdentity.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Data.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
       [MaxLength(100)]
        public String Title { get; set; }
         public String? Description { get; set; }
        public Boolean IsActive { get; set; }
        public Category Category { get; set; }//Navigation property
        public int CategoryId { get; set; }
    }
}
