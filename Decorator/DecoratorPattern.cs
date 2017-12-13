using System;

namespace Decorator
{
    public class DecoratorPattern
    {
        public static void Main()
        {
            var book = new Book("Book Author", "Book Title", 5);
            book.Display();

            var video = new Video("Video Author", "Video Title", 120, 3);
            video.Display();

            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowVideo = new Borrowable(video);
            borrowVideo.BorrowItem("Customer #1");
            borrowVideo.BorrowItem("Customer #2");

            borrowVideo.Display();
        }
    }
}