namespace Lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album album1 = new Album();
            album1.ShowAlbumInfo();
            Album album2 = new Album()
            {
                AlbumAuthor = "WP",
                ReleaseYear = 2000
            };
            album2.ShowAlbumInfo();
            Album album3 = new Album("WWWa", "JPII", 2137, 2004);
            album3.ShowAlbumInfo();
            Album album4 = new Album("Sssa", 2004);
            album4.ShowAlbumInfo();
            Album album5 = new Album("OP", "W", 5, 2014);
            album5.ShowAlbumInfo();
            Console.WriteLine($"Number of Albums {Album.HowManyAlbums}");
            Album.CleanAlbumCounter();
            Console.WriteLine($"Number of Albums after reset {Album.HowManyAlbums}");
        }
    }
}
