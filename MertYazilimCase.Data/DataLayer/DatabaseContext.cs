using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MertYazilimCase.Data.Models;

namespace MertYazilimCase.Data.DataLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
       : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=localhost;Initial Catalog=MertYazilimCase;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<WorkStation> WorkStations { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Alarm> Alarms { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
    }
}
