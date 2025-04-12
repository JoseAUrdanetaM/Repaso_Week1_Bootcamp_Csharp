using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_POO
{
    internal class Song
    {

        public string Album { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        public string Genre { get; set; }
        public Song(string album, string name, string description, string genre)
        {
            Album = album;
            Name = name;
            Description = description;
            Genre = genre;
        }
    }
}
