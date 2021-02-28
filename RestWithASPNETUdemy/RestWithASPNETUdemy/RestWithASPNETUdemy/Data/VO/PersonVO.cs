﻿//using System.Text.Json.Serialization;

using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstact;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Data.VO
{

    public class PersonVO : ISupportsHyperMedia
    {
        //[JsonPropertyName("code")]
        public long Id { get; set; }
        //[JsonPropertyName("name")]
        public string FirstName { get; set; }
        //[JsonPropertyName("last_name")]
        public string LastName { get; set; }
        //[JsonIgnore]
        public string Address { get; set; }
        //[JsonPropertyName("sex")]
        public string Gender { get; set; }
        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
