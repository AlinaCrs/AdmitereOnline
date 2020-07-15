using AdmitereOnline.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmitereOnline.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Role> Roles {get; set;}
    }
}