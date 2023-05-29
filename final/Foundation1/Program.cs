using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video vid1 = new Video("Best of Blake Bortles", "Jason Mendoza", 600);
        vid1.AddComment(new Comment("Elenor Shellstrop", "Why are you so obsessed with Blake Bortles??"));
        vid1.AddComment(new Comment("Jason Mendoza", "uh because hes the best ever DUVALLLLLL"));
        vid1.AddComment(new Comment("Chidi", "Kant is better imo."));

        Video vid2 = new Video("John Doe", "How to be unique when you have a basic name - a guide for men", 900);
        vid2.AddComment(new Comment("John Doe", "For more information follow me on Pateron -> -> ->"));
        vid2.AddComment(new Comment("John Smith", "Hoping to finally get noticed <3"));
        vid2.AddComment(new Comment("Joe", "Nice man!"));

        Video vid3 = new Video("Elizabeth Bennet", "All the reasons Mr. Darcy is prideful and vain.", 1200);
        vid3.AddComment(new Comment("Fitzwilliam Darcy", "Wow, I think you're being a little prejudiced."));
        vid3.AddComment(new Comment("Jane Bennet", "Lizzie he cannot be all that bad, maybe you misunderstood his motives."));
        vid3.AddComment(new Comment("Ms. Bingley", "Mr. Darcy can do no wrong, he is a man without flaws. <3 <3 <3"));

        foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.title}");
                Console.WriteLine($"Author: {video.author}");
                Console.WriteLine($"Length (in seconds): {video.length}");
                Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
                }

                Console.WriteLine();
            }



    }
}