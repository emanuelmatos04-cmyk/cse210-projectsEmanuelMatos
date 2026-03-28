using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Introduction to C#", "María López", 600, new List<Comment>());
        v1.AddComment("José", "Great explanation, very clear.");
        v1.AddComment("Ana", "This helped me understand a lot.");
        v1.AddComment("Luis", "Thanks for sharing this content.");
        videos.Add(v1);

        Video v2 = new Video("Object-Oriented Programming Concepts", "Carlos Pérez", 720, new List<Comment>());
        v2.AddComment("Sofía", "Very good example of classes.");
        v2.AddComment("Miguel", "Now I understand inheritance better.");
        v2.AddComment("Valeria", "I loved the way you explained.");
        videos.Add(v2);

        Video v3 = new Video("Collections in C#", "Lucía Fernández", 500, new List<Comment>());
        v3.AddComment("Andrés", "The part about lists was very useful.");
        v3.AddComment("Paola", "I liked how you explained dictionaries.");
        v3.AddComment("Diego", "Excellent course, thank you.");
        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}
