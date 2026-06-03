using Microsoft.EntityFrameworkCore;

namespace WebAppMVCTechCrew.Models
{
    public class AppDb : DbContext
    {

        // connection string
        public AppDb(DbContextOptions<AppDb> options) : base(options) 
        {
        }
        public DbSet<UsersModel> Users { get; set; }    
    }
}
