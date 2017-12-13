using System;

namespace Decorator
{
    public class Video : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;
        private readonly int _playTime;

        public Video(string author, string title, int playTime, int numCopies)
        {
            _author = author;
            _title = title;
            _playTime = playTime;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo -------");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Play Time: {_playTime}");
            Console.WriteLine($" # Copies: {NumCopies}");
        }
    }
}