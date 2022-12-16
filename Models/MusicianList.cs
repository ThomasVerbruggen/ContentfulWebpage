using System;
using Contentful.Core.Models;

namespace MusicianList.Models
{
    public class MusiciansList
    {
        public string Name { get; set; }

        public string Instrument { get; set; }

        public Asset Picture { get; set; }
    }
}

