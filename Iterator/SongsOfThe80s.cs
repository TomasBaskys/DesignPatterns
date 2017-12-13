using System.Collections;

namespace Iterator
{
    public class SongsOfThe80s : ISongIterator
    {
        private readonly SongInfo[] _bestSongs;
        private int _arrayIterator;

        public SongsOfThe80s()
        {
            _bestSongs = new SongInfo[3];

            AddSong("Roam", "B 52s", 1989);
            AddSong("Cruel Summer", "Bananarama", 1984);
            AddSong("Head Over Heels", "Tears For Fears", 1985);
        }

        /*public SongInfo[] GetBestSongs()
        {
            return _bestSongs;
        }*/

        public IEnumerator CreateIterator()
        {
            return _bestSongs.GetEnumerator();
        }

        private void AddSong(string name, string band, int yearReleased)
        {
            _bestSongs[_arrayIterator] = new SongInfo(name, band, yearReleased);

            _arrayIterator++;
        }
    }
}