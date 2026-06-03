class Program
{
    static void Main(string[] args)
    {
        // Create 4 videos
        Video video1 = new Video("How to Learn C# Fast", "TechTeacher", 720);
        Video video2 = new Video("Banking Tips for Beginners", "FinancePro", 1250);
        Video video3 = new Video("Why Encapsulation is Important", "CodeWithMe", 850);

        // Add comments to video 1
        video1.AddComment(new Comment("Sarah123", "This helped me so much!"));
        video1.AddComment(new Comment("MikeTheCoder", "Best tutorial ever"));
        video1.AddComment(new Comment("AnnaLee", "Thank you!!"));

        // Add comments to video 2
        video2.AddComment(new Comment("JohnBanker", "Very useful tips"));
        video2.AddComment(new Comment("MoneySaver22", "I learned a lot"));
        video2.AddComment(new Comment("EmilyR", "Can you make a part 2?"));

        // Add comments to video 3
        video3.AddComment(new Comment("CSharpFan", "This explains it perfectly"));
        video3.AddComment(new Comment("BeginnerDev", "Now I understand encapsulation"));
        video3.AddComment(new Comment("TechGuru99", "Great example"));

        // Put all videos in a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}