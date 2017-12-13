using System;
using System.Collections;

namespace Iterator
{
    public class DiscJockey
    {
        private readonly ISongIterator _iter70sSongs;
        private readonly ISongIterator _iter80sSongs;
        private readonly ISongIterator _iter90sSongs;

        public DiscJockey(ISongIterator iter70SSongs, ISongIterator iter80SSongs, ISongIterator iter90SSongs)
        {
            _iter70sSongs = iter70SSongs;
            _iter80sSongs = iter80SSongs;
            _iter90sSongs = iter90SSongs;
        }

        public void ShowTheSongs()
        {
            IEnumerator songs70s = _iter70sSongs.CreateIterator();
            IEnumerator songs80s = _iter80sSongs.CreateIterator();
            IEnumerator songs90s = _iter90sSongs.CreateIterator();

            Console.WriteLine("\n\nSongs of the 70s\n");
            PrintTheSongs(songs70s);

            Console.WriteLine("\n\nSongs of the 80s\n");
            PrintTheSongs(songs80s);

            Console.WriteLine("\n\nSongs of the 90s\n");
            PrintTheSongs(songs90s);
        }

        private void PrintTheSongs(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                SongInfo song = (SongInfo)iterator.Current;

                Console.WriteLine($"{song.Name}\t{song.Band}\t{song.YearReleased}");
            }
        }
    }
}