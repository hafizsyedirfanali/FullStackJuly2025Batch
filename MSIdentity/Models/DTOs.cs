using MSIdentity.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace MSIdentity.Models;
/// <summary>
/// a record is similar to class that can hold data/record
/// </summary>
public record BookDTO//Data Transfer Object
{
    public int Id { get; set; }
    [MaxLength(100)]
    public String Title { get; set; }
    public String? Description { get; set; }
    public Boolean IsActive { get; set; }
    public int CategoryId { get; set; }
}
public record CategoryDTO {public int Id; public string Name; public string? Description; public bool IsAction; }