using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Clases
{
    internal class Song
    {
        private string _name; // access modifier
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private string artist;
        private string genre;
        private string albumName;
        private int durationSeconds;
        public Song(string name, string artist, string genre, string albumName, int durationSeconds)
        {
            this.name = name;
            this.artist = artist;
            this.genre = genre;
            this.albumName = albumName;
            this.durationSeconds = durationSeconds;
        }

        public Song(string name, string artist, string albumName, int durationSeconds)
        {
            this.name = name;
            this.artist = artist;
            this.albumName = albumName;
            this.durationSeconds = durationSeconds;
        }


        public string mostrarNombreCancion(string nombre)
        {
            return name + "" + nombre;

        }

    }
}
