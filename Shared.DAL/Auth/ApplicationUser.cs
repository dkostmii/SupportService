using Microsoft.AspNetCore.Identity;

namespace Shared.DAL.Auth;

public class ApplicationUser : IdentityUser
{
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
}

