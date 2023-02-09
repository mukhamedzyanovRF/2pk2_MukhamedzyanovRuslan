using Microsoft.VisualBasic;
using System;

namespace pz_21
{
    public class Track 
    {
        public override string ToString()
        {
            return string.Format($"Исполнитель: {Author} название: {Title} Альбом: {Album} Год выхода: {Year} Битрейт: {Bitrate} Тип кодека: {Type}");
        }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int Bitrate { get; set; }
        public string Type { get; set; }


        public void PrintInfo (string author, string title, string album, int year, int bitrate, string type)
        {
            Author = author;
            Title = title;
            Album = album;
            Year = year;
            Bitrate = bitrate;
            Type = type;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Track pr = new Track();
            pr.PrintInfo("MORGENSHTERN", "BUGGATTI", "BUGGATTI", 2022, 256, "MP3");
            Console.WriteLine(pr);
            pr.PrintInfo("System of a Down", "cigaro", "Mezmeruze", 2005, 256, "AAC");
            Console.WriteLine(pr);
            pr.PrintInfo("GHOSTEMANE", "Mercury: Retrograde", "Hexade", 2017, 256, "FLAC");
            Console.WriteLine(pr);
        }
    }
}