using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learning C#", "Ukeje frank Chika", 600);
        Video video2 = new Video("Forex Trading Basics", "Market Pro", 900);
        Video video3 = new Video("Web Development Guide", "Code Master", 1200);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("John", "I learned a lot!"));

        // Add comments to video 2
        video2.AddComment(new Comment("Sarah", "Nice explanation."));
        video2.AddComment(new Comment("Mike", "Can you do more videos?"));
        video2.AddComment(new Comment("David", "This helped me understand trading."));

        // Add comments to video 3
        video3.AddComment(new Comment("Emma", "Awesome content!"));
        video3.AddComment(new Comment("Chris", "Very detailed."));
        video3.AddComment(new Comment("Sophia", "Thanks for sharing!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}