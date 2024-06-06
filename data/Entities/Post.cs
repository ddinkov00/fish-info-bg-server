namespace data;

public class Post
{
    public Post()
    {
        this.Images = [];
        this.Likes = [];
    }

    public int Id { get; set; }

    public string Description { get; set; }

    public DateTime Created { get; set; }

    public double? LocationLatitude { get; set; }

    public double? LocationLongitude { get; set; }

    public Guid ApplicationUserId { get; set; }

    public ApplicationUser ApplicationUser { get; set; }

    public ICollection<PostImage> Images { get; set; }

    public ICollection<Like> Likes { get; set; }
}
