using MusicCatalog.Models;

namespace MusicCatalog.Services
{
    public class TrackMediator
    {
        public event Action<Track> TrackAdded;

        public void AddTrack(Track track)
        {
            TrackAdded?.Invoke(track);
        }
    }
}
