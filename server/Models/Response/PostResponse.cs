using AutoMapper;
using data;

namespace server;

public class PostResponse
{
    public int Id { get; set; }

    public string Description { get; set; }

    public string Username { get; set; }

    public double? LocationLatitude { get; set; }

    public double? LocationLongitude { get; set; }

    public int Likes { get; set; }

    public bool IsLiked { get; set; }

    public DateTime Created { get; set; }

    public IEnumerable<string> ImagesUrl { get; set; }
}

public class PostResponseProfile : Profile
{
    public PostResponseProfile()
    {
        this.CreateMap<Post, PostResponse>()
            .ForMember(dest => dest.ImagesUrl, opt => opt.MapFrom(src => src.Images.Select(x => x.Url)))
            .ForMember(dest => dest.Likes, opt => opt.MapFrom(src => src.Likes.Count()))
            .ForMember(dest => dest.Likes, opt => opt.MapFrom(src => false))
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.ApplicationUser.UserName));
    }
}
