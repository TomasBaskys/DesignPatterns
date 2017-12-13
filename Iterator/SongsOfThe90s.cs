using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class SongsOfThe90s : ISongIterator
    {
        private readonly HashSet<SongInfo> _bestSongs;

        public SongsOfThe90s()
        {
            _bestSongs = new HashSet<SongInfo>();

            AddSong("Losing My Religion", "REM", 1991);
            AddSong("Creep", "Radiohead", 1993);
            AddSong("Walk on the Ocean", "Toad The Wet Sprocket", 1991);
        }

        /*public HashSet<SongInfo> GetBestSongs()
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