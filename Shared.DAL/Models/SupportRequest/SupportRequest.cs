using System.ComponentModel.DataAnnotations;

namespace Shared.DAL.Models.SupportRequest;

public class SupportRequest : BaseEntity
{
    [Required]
    public required Client Client { get; set; }
    
    public Manager? Manager { get; set; }

    [Required]
    public required string State { get; set; }

    [Required]
    public required SupportRequestCategory Category { get; set; }
}

