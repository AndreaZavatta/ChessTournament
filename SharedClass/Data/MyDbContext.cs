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
        public DbSet<Persona> Persone { get; set; }
        public DbSet<Giocatore> Giocatori { get; set; }
        public DbSet<Allenatore> Allenatori { get; set; }
        public DbSet<Allenamento> Allenamenti { get; set; }

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

    }
}
