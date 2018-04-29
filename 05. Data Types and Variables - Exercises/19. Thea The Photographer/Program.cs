using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long takenPictures = long.Parse(Console.ReadLine());
            long filterTimeOnePicture = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filterTimeAllPictures = takenPictures * filterTimeOnePicture;
            double filteredPictures = Math.Ceiling(takenPictures * (filterFactor / 100.0));
            double filteredPicturesUploadTime = filteredPictures * uploadTime;

            double totalTime = filterTimeAllPictures + filteredPicturesUploadTime;

            TimeSpan clock = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine($"{clock.Days:D1}:{clock.Hours:D2}:{clock.Minutes:D2}:{clock.Seconds:D2}");
        }
    }
}