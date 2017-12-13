namespace Iterator
{
    public class SongInfo
    {
        public string Name { get; }
        public string Band { get; }
        public int YearReleased { get; }

        public SongInfo(string name, string band, int yearReleased)
        {
            Name = name;
            Band = band;
            YearReleased = yearReleased;
        }
    }
}
