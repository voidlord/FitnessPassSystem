using FitnessPass.Model;
using FitnessPassApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.DB
{
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PassType> PassType { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Entries> Entries { get; set; }
        public DbSet<Gym> Gym { get; set; }
        public DbSet<ClientPass> ClientPass { get; set; }
        public DbSet<User> User { get; set; }
    }
}
