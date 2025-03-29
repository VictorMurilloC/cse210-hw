using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Tutorial", "David", 60);
        v1.AddComment("Eva", "This was very informative, thanks!");
        v1.AddComment("Frank", "I learned a lot, great content!");
        v1.AddComment("David", "I appreciate the feedback, glad you liked it!");

        videos.Add(v1);

        Video v2 = new Video("Python Tutorial", "Eva", 45);
        v2.AddComment("David", "Nice work, I'll try this out!");
        v2.AddComment("Frank", "Super clear explanation, loved it!");
        v2.AddComment("Eva", "Thanks for watching, hope it helps!");
        videos.Add(v2);

        Video v3 = new Video("Java Tutorial", "Frank", 30);
        v3.AddComment("Eva", "This is so helpful, thanks for sharing!");
        v3.AddComment("David", "Great job on the tutorial, very easy to follow.");
        v3.AddComment("Frank", "Thanks for the support, I hope you found it useful!");
        v3.AddComment("Eva", "Awesome breakdown of the concepts!");

        videos.Add(v3);

        foreach (Video v in videos) {
            Console.WriteLine("Title: " + v._title);
            Console.WriteLine("Author: " + v._author);
            Console.WriteLine("Time in Seconds: "+ v._secondsLength);
            Console.WriteLine("Number of Comments: "+v.GetNumberOfComments());
        }
    }
}
