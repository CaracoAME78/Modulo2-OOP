namespace Repaso_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Song song = new Song();
            Console.WriteLine(song.name);
        }

        public class Song
        {
            public string name;
            public string artist;
            public string genre;
            public string albumName;
            public int durationSeconds;
        }
    }
}
