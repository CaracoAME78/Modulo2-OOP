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
        public string NamePublic
        {
            get => _name;
            set => _name = value;
        }
        public string artist;
        public string genre;
        public string albumName;
        public int durationSeconds;
        public Song(string name, string artist, string genre, string albumName, int durationSeconds)
        {
            this._name = name;
            this.artist = artist;
            this.genre = genre;
            this.albumName = albumName;
            this.durationSeconds = durationSeconds;
        }

        public Song(string name, string artist, string albumName, int durationSeconds)
        {
            this._name = name;
            this.artist = artist;
            this.albumName = albumName;
            this.durationSeconds = durationSeconds;
        }


        public string mostrarNombreCancion(string nombre)
        {
            return _name + "" + nombre;

        }

    }
}
