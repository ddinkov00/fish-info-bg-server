using Microsoft.AspNetCore.Identity;

namespace data;

public class ApplicationUser : IdentityUser<Guid>
{
    public ApplicationUser() : base()
    {
        this.Posts = [];
    }

    public ICollection<Post> Posts { get; set; }
}
