using Microsoft.AspNetCore.Identity;

namespace MusiKup.Domain.Entities;

public class User : IdentityUser<Guid>
{

    public User(Guid id)
    {
        Id = id;
    }
}