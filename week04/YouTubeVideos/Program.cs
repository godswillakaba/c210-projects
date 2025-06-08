using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video {Title = "How to cook spaghetti", Author = "Chef Johnson", Length = 420};
        video1.AddComment(new Comment("Ama", "Delicios recipe!"));
        video1.AddComment(new  Comment("John", "I tried it and I love it"));
        video1.AddComment(new Comment("Linda", "Very helpful, thanks"));
        videos.Add(video1);

        //Video 2
        Video video2 = new Video {Title = "Understanding Abstraction", Author = "Otto Lyes", Length = 370};
        video2.AddComment(new Comment("Marie", "I get it now"));
        video2.AddComment(new  Comment("Mark", "You made the very easy to understand "));
        video2.AddComment(new Comment("Ann", "Very helpful thanks"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video {Title = "Learn how to code in 5 minutes", Author = "Spencer", Length = 300};
        video3.AddComment(new Comment("Jude", "Are you serious?!"));
        video3.AddComment(new  Comment("Luke", "I can't still do it"));
        video3.AddComment(new Comment("R.K", "It's taking me forever to understand your explanation"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video {Title = "Entry level remote jobs", Author = "Lee Chi", Length = 610};
        video4.AddComment(new Comment("Kim", "Please share the link to the second company"));
        video4.AddComment(new  Comment("Hope", "Hope to get one soon"));
        video4.AddComment(new Comment("Luca", "Very helpful, thanks"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}