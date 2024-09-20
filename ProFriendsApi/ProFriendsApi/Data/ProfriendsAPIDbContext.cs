using Microsoft.EntityFrameworkCore;
using ProFriendsApi.Models;

namespace ProFriendsApi.Data
{
    public class ProfriendsAPIDbContext : DbContext
    {
        public ProfriendsAPIDbContext(DbContextOptions<ProfriendsAPIDbContext> options)
            :base(options)
        { 
            
        }

        public DbSet<ProFriendsAPI> ProFriendsAPI {  get; set; }
    }
}
