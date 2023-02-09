using Microsoft.VisualBasic;
using System;

namespace pz_22
{
    public class Track
    {
        public bool correct;
        public override string ToString()
        {
            if (correct)
            {
                return string.Format($"Исполнитель: {Author} название: {Title} Альбом: {Album} Год выхода: {Year} Битрейт: {Bitrate} Тип кодека: {Type}");
            }
            else
            {
                return string.Format("Ошибка");
            }
            

        }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int Bitrate { get; set; }
        public string Type { get; set; }

        public void PrintInfo(string author, string title, string album, int year, int bitrate, string type)
        {

            if ((author != "" && title != "" && album != "") && (year > 1990 && year <= 2022) && (type == "MP3" || type == "AAC" || type == "FLAC"))
            {
                Author = author;
                Title = title;
                Album = album;
                Year = year;
                Bitrate = bitrate;
                Type = type;
                correct = true;
            }
            else
            {
                correct = false;
            }



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Track pr = new Track();
            pr.PrintInfo("MORGENSHTERN", "BUGGATTI", "BUGGATTI", 2023, 256, "MP3");
            Console.WriteLine(pr);
            pr.PrintInfo("System of a Down", "cigaro", "Mezmeruze", 2005, 256, "AAC");
            Console.WriteLine(pr);
            pr.PrintInfo("GHOSTEMANE", "Mercury: Retrograde", "Hexade", 2017, 256, "FLAC");
            Console.WriteLine(pr);
        }
    }
}