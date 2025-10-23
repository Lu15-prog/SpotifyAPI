using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpotifyAPI.Models;

namespace SpotifyAPI.Data
{
    public class SpotifyContext : DbContext
    {
        public SpotifyContext(DbContextOptions<SpotifyContext> options) : base(options) { }

        public DbSet<Musica> Musicas { get; set; }
    }
}