using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Context.Data
{

    public class MyDbContext : DbContext
    {
        public DbSet<Allenamento> Allenamenti { get; set; }
        public DbSet<Allenatore> Allenatori { get; set; }
        public DbSet<Commento> Commenti { get; set; }
        public DbSet<Competizione> Competizioni { get; set; }
        public DbSet<Edizione> Edizioni { get; set; }
        public DbSet<Giocatore> Giocatori { get; set; }
        public DbSet<Iscritto> Iscritti { get; set; }
        public DbSet<Lezione> Lezioni { get; set; }
        public DbSet<Luogo> Luoghi { get; set; }
        public DbSet<Mossa> Mosse { get; set; }
        public DbSet<Organizzatore> Organizzatori { get; set; }
        public DbSet<Partita> Partite { get; set; }
        public DbSet<Persona> Persone { get; set; }
        public DbSet<Torneo> Tornei { get; set; }




        protected string ConnectionString { get; }

        public MyDbContext(string connectionString)
            : base()
        {
            ConnectionString = connectionString;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrWhiteSpace(ConnectionString))
                optionsBuilder.UseMySQL(ConnectionString);
            //optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competizione>().HasNoKey();
            modelBuilder.Entity<Mossa>().HasNoKey();
        }
    }
}
