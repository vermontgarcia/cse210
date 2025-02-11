using System;

class Program
{
    static private List<Video> _videos = [];

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Video tracker!");
        Console.WriteLine();
        GenerateVideos();
        ShowVideoCollection();
    }

    private static void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    private static void GenerateVideos()
    {
        Video video1 = new("Funny Video", "Chris Nolan", 65);

        Comment comment1Video1 = new("Chuckles McGee", "This video cured my boredom and gave my neighbors something to complain about—my uncontrollable laughter!");
        Comment comment2Video1 = new("Gigglesaurus Rex", "I almost choked on my cereal watching this. 10/10 would risk it again!");
        Comment comment3Video1 = new("Captain LOL", "I laughed so hard, even my dog gave me the side-eye. Thanks for the ab workout!");
        Comment comment4Video1 = new("Snarky McSnortface", "This is why the internet was invented. Pure comedy gold");
        Comment comment5Video1 = new("Laughing Larry", "I showed this to my grandma, and now she wants to start her own YouTube channel!");

        video1.AddComment(comment1Video1);
        video1.AddComment(comment2Video1);
        video1.AddComment(comment3Video1);
        video1.AddComment(comment4Video1);
        video1.AddComment(comment5Video1);

        AddVideo(video1);

        Video video2 = new("Interesting Video", "Brad Pit", 302);

        Comment comment1Video2 = new("Curious Carla", "This is the kind of content that makes me forget what I was originally searching for. Fascinating!!");
        Comment comment2Video2 = new("Brainy Baxter", "I came for a quick watch and stayed for a deep dive into awesomeness. Mind = blown!");
        Comment comment3Video2 = new("Nugget Ned", "Finally, a video that makes me feel smarter after watching it. Bravo!");
        Comment comment4Video2 = new("Thinkerbell", "How did I not know about this before? I’m officially obsessed now!");

        video2.AddComment(comment1Video2);
        video2.AddComment(comment2Video2);
        video2.AddComment(comment3Video2);
        video2.AddComment(comment4Video2);

        AddVideo(video2);

        Video video3 = new("AWkward Video", "Tylor Swift", 173);

        Comment comment1Video3 = new("Awkward Andy", "I’ve never cringed and laughed this hard at the same time. My secondhand embarrassment is off the charts!");
        Comment comment2Video3 = new("Cringe Queen Kathy", "This video is like a car crash—I can’t look away, but I probably should.");
        Comment comment3Video3 = new("Toe-Curlin’ Tim", "This gave me the same vibe as accidentally waving back at someone who wasn’t waving at me.");
        Comment comment4Video3 = new("Socially Stuck Sam", "This feels like watching myself try to leave a Zoom call but forgetting how to click 'leave meeting.' Painful yet iconic.");
        Comment comment5Video3 = new("Blushing Benny", "I paused three times just to process the awkwardness. Honestly, this is an art form.");

        video3.AddComment(comment1Video3);
        video3.AddComment(comment2Video3);
        video3.AddComment(comment3Video3);
        video3.AddComment(comment4Video3);
        video3.AddComment(comment5Video3);

        AddVideo(video3);

        Video video4 = new("Random Video", "Unknown", 25);

        Comment comment1Video4 = new("Confused Carl", "I don’t know why this exists, but I’m glad it does.");
        Comment comment2Video4 = new("Wanda", "This is the kind of content the algorithm serves me at 3 AM, and I’m not even mad.");
        Comment comment3Video4 = new("Chaotic Chris", "I was just here looking for pasta recipes, but now I’m emotionally invested in this.");
        Comment comment4Video4 = new("Random Ricky", "I don’t know what I just watched, but it’s now my new favorite thing.");
        Comment comment5Video4 = new("Spontaneous Sarah", "This video feels like a fever dream, and I’m absolutely here for it.");

        video4.AddComment(comment1Video4);
        video4.AddComment(comment2Video4);
        video4.AddComment(comment3Video4);
        video4.AddComment(comment4Video4);
        video4.AddComment(comment5Video4);

        AddVideo(video4);
    }

    private static void ShowVideoCollection()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine();
            foreach (string comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }
    }
}
