using System.ComponentModel.DataAnnotations;

namespace MSIdentity.Data.Entities
{
    public class Book //child table
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public String Title { get; set; }
        public String? Description { get; set; }
        public Boolean IsActive { get; set; }
        public Category Category { get; set; }//Navigation property
        public int CategoryId { get; set; }//parent table id
    }
}
