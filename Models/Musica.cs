using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyAPI.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Artista { get; set; }
        public string Mp3Base64 { get; set; }
        public string AlbumImagemBase64 { get; set; }
    }
}