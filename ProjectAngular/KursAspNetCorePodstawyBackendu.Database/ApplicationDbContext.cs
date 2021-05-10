using Microsoft.EntityFrameworkCore;
using System;

namespace KursAspNetCorePodstawyBackendu.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MessageEntity> Messages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
