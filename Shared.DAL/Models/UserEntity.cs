using System.ComponentModel.DataAnnotations;

namespace Shared.DAL.Models;

public abstract class UserEntity : BaseEntity
{
    [Required]
    [MinLength(3)]
    [MaxLength(40)]
    public required string FirstName { get; set; }
    
    [MinLength(3)]
    [MaxLength(60)]
    public string? LastName { get; set; }

    [Required]
    [EmailAddress]
    public required string EmailAddress { get; set; }
    public string? PhoneNumber { get; set; }
}

