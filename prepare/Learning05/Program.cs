using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 120);
        Video video2 = new Video("Video 2", "Author 2", 240);
        Video video3 = new Video("Video 3", "Author 3", 360);

        // Add comments to videos
        video1.AddComment("User 1", "Great video!");
        video1.AddComment("User 2", "I learned a lot from this.");
        video2.AddComment("User 3", "Interesting content.");
        video3.AddComment("User 4", "Keep up the good work!");

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}s, Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }
        }
    }
}