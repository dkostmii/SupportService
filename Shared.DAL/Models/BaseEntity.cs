using System.ComponentModel.DataAnnotations;

namespace Shared.DAL.Models;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}

