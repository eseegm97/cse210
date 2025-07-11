using System;

class Program {
    static void Main(string[] args) {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("My First Video", "Jane Doe", 5);
        video1.AddComment(new Comment("User123", "Great video!"));
        video1.AddComment(new Comment("Alice", "Loved it!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        videos.Add(video1);

        Video video2 = new Video("Cooking Basics", "Chef Mike", 10);
        video2.AddComment(new Comment("Foodie", "Yummy recipe!"));
        video2.AddComment(new Comment("ChefAnna", "Nice explanation."));
        video2.AddComment(new Comment("GourmetGuy", "Thanks for sharing!"));
        video2.AddComment(new Comment("GrillMaster", "Mine didn't turn out like that..."));
        videos.Add(video2);
        
        Video video3 = new Video("Short Update", "Dan's Diary", 3);
        video3.AddComment(new Comment("Sarah1000", "Excited about the news!"));
        video3.AddComment(new Comment("NetSurfer", "Thanks for the update!"));
        video3.AddComment(new Comment("JimmyJazz", "Staying tuned for more!"));
        videos.Add(video3);

        Video video4 = new Video("New Movie Review", "Cinema Centurian", 20);
        video4.AddComment(new Comment("Fanboy450", "I'll have to see this one!"));
        video4.AddComment(new Comment("Nerdette", "I liked it too!"));
        video4.AddComment(new Comment("EagerBeaver", "What will you review next?"));
        video4.AddComment(new Comment("HorrorJunkie365", "Wasn't scary enough for me..."));
        video4.AddComment(new Comment("ComicBookGuy", "Worst. Movie. Ever."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLengthInSeconds() + " minutes");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(" - " + comment.GetCommenterName() + ": " + comment.GetCommentText());
            }
            Console.WriteLine();
        }
    }
}