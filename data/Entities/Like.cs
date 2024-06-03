namespace data;

public class Like
{
    public int Id { get; set; }

    public int PostId { get; set; }

    public Post Post { get; set; }

    public Guid UseId { get; set; }

    public int UserId { get; set; }

    public ApplicationUser User { get; set; }
}
