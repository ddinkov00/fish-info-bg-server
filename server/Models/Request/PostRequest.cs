using AutoMapper;
using data;
using Microsoft.AspNetCore.SignalR;
using System.Formats.Asn1;

namespace server;

public class PostRequest
{
    public string Description { get; set; }

    public IEnumerable<string> ImagesUrl { get; set; }

    public double? LocationLatitude { get; set; }

    public double? LocationLongitude { get; set; }
}

public class PostRequestProfile : Profile
{
    public PostRequestProfile()
    {
        this.CreateMap<PostRequest, Post>()
            .ForMember(src => src.ApplicationUserId, opt => opt.Ignore())
            .ForMember(src => src.Images, opt => opt.MapFrom(dest => dest.ImagesUrl
                .Select(x => new PostImage { Url = x })))
            .ForMember(src => src.Created, opt => opt.MapFrom(dest => DateTime.UtcNow));
    }
}
