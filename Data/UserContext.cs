using Microsoft.EntityFrameworkCore;
using SIMPLEWEBAPI.Models;

namespace SIMPLEWEBAPI.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public string DbPath { get; }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "userRegistration.db");
        }

    }
}
