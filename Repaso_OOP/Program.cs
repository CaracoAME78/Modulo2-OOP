using Repaso_OOP.Clases;

namespace Repaso_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Song song = new Song("Something About Us","Daft Punk","Electronic","Discovery",240);
            Console.WriteLine(song.NamePublic);
            Console.WriteLine(song.artist);
            Console.WriteLine(song.genre);
            Console.WriteLine(song.albumName);
            Console.WriteLine(song.durationSeconds);

            Song song2 = new Song("Around the Word", "Daft Punk", "Electronic", "Discovery", 240);
            Console.WriteLine(song.NamePublic);
            Console.WriteLine(song.artist);
            Console.WriteLine(song.genre);
            Console.WriteLine(song.albumName);
            Console.WriteLine(song.durationSeconds);

            Song song3 = new Song("Get Lucky",  "Electronic", "Ramdom Acces Memories", 240);
            Console.WriteLine(song.NamePublic);
            Console.WriteLine(song.artist);
            Console.WriteLine(song.genre);
            Console.WriteLine(song.albumName);
            Console.WriteLine(song.durationSeconds);
            song3.genre = "Electronic";
        }

        
      
    }
}
