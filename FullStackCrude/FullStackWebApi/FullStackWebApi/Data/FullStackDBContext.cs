using FullStackWebApi.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace FullStackWebApi.Data
{
    public class FullStackDBContext : DbContext
    {
        public FullStackDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
