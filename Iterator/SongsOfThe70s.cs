using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class SongsOfThe70s : ISongIterator
    {
        private readonly List<SongInfo> _bestSongs;

        public SongsOfThe70s()
        {
            _bestSongs = new List<SongInfo>();

            AddSong("Imagine", "John Lennon", 1971);
            AddSong("American Pie", "Don McLean", 1971);
            AddSong("I Will Survive", "Gloria Gaynor", 1979);
        }

        /*public List<SongInfo> GetBestSongs()
        {
            return _bestSongs;
        }*/

        public IEnumerator CreateIterator()
        {
            return _bestSongs.GetEnumerator();
        }

        private void AddSong(string name, string band, int yearReleased)
        {
            _bestSongs.Add(new SongInfo(name, band, yearReleased));   
        }
    }
}