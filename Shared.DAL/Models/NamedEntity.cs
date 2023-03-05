using System.ComponentModel.DataAnnotations;

namespace Shared.DAL.Models;

public abstract class NamedEntity : BaseEntity
{
    [Required]
    public required string Name { get; set; }
}

