using CoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){ }

        public DbSet<Value> Values { get; set; }
    }
}