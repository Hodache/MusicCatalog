using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCatalog.Models.MusicCollections
{
    class Album(string name, List<Track> tracks, Artist artist, DateTime dateTime) : MusicCollection(name, tracks)
    {
        public Artist Artist { get; } = artist;
        public DateTime ReleaseDate { get; } = dateTime;
    }
}
