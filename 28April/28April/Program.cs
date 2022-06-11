using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _29_03_2022_HomeWork.Models;

namespace _29_03_2022_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Bulutlara esir olduk", "pop");
            song.Singer = new Singer("Oguzhan", "Koc", 35);
            Console.WriteLine($"\nName - {song.Singer.Name}, Surname - {song.Singer.Surname}, Age - {song.Singer.Age}");
            Console.WriteLine($"\nSong Name - {song.Name}, Genre - {song.Genre}");
            song.AddRating(7);
            song.AddRating(8);
            Console.WriteLine(song.GetAverageRating());

        }
    }
}