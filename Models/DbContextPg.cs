using Microsoft.EntityFrameworkCore;

namespace Activity.Models
{
    public class DbContextPg : DbContext
    {
        public DbContextPg(DbContextOptions<DbContextPg> options) : base(options)
        {

        }

        public DbSet<ActivityModel> Activity { get; set; }
        public DbSet<UsersModel> Users { get; set; }
    }
}