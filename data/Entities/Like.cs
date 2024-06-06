namespace data;

public class Like
{
    public int Id { get; set; }

    public int PostId { get; set; }

    public Post Post { get; set; }

    public Guid ApplicationUserId { get; set; }

    public ApplicationUser ApplicationUser { get; set; }
}
