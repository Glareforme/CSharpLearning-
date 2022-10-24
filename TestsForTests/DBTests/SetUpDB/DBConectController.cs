using DBTests.Models;
using Microsoft.EntityFrameworkCore;
using DBTests.DataForTest.Constants;

namespace DBTests.SetUpDB
{
    public class DBConectController : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConstForTests.DataBaseConnectString);
        }
    }
}