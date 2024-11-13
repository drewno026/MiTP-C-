using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Album
    {
        public string AlbumTitle { get; set; }
        public string AlbumAuthor { get; set; }
        public int NumberOfSongs {  get; set; }
        public int ReleaseYear { get; set; }

        public static int HowManyAlbums { get; set; } = 0;

        public Album()
        {
            AlbumTitle = "Unknown";
            AlbumAuthor = "Unknown";
            NumberOfSongs = 0;
            ReleaseYear = 0;
            HowManyAlbums++;
        }
        public Album(string albumTitle, string albumAuthor, int numberOfSongs, int releaseYear)
        {
            AlbumTitle = albumTitle;
            AlbumAuthor = albumAuthor;
            if (numberOfSongs < 0)  
            {
                throw new ArgumentException("Number of songs must be greater than zero");
            }
            else
            {
                NumberOfSongs = numberOfSongs;
                int CurrentYear = DateTime.Now.Year;
                if (releaseYear > CurrentYear || releaseYear <= (CurrentYear - 80))
                {
                    throw new ArgumentException("Year must be realistic");
                }
                else
                {
                    ReleaseYear = releaseYear;
                }
            }
            HowManyAlbums++;
        }
        public Album(string albumTitle, int releaseYear) : this()
        {
            AlbumTitle = albumTitle;
            int CurrentYear = DateTime.Now.Year;
            if (releaseYear > CurrentYear || releaseYear <= (CurrentYear - 80))
            {
                throw new ArgumentException("Year must be realistic");
            }
            else
            {
                ReleaseYear = releaseYear;
            }
        }

        public static void CleanAlbumCounter()
        {
            HowManyAlbums = 0;
        }
            public void ShowAlbumInfo()
        {
            Console.WriteLine("Album details: ");
            Console.WriteLine(AlbumTitle);
            Console.WriteLine(AlbumAuthor);
            Console.WriteLine(NumberOfSongs);
            Console.WriteLine(ReleaseYear + "\n");
        }

    }
}
