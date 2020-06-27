using AdmitereOnline.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmitereOnline.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}