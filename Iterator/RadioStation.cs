namespace Iterator
{
    public class RadioStation
    {
        public static void Main()
        {
            var songs70s = new SongsOfThe70s();
            var songs80s = new SongsOfThe80s();
            var songs90s = new SongsOfThe90s();

            var madMike = new DiscJockey(songs70s, songs80s, songs90s);

            madMike.ShowTheSongs();
        }
    }
}