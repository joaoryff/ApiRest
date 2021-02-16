using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermedia.Abstact
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
