using Microsoft.EntityFrameworkCore;
using MyLuckyTicket.Models;

namespace MyLuckyTicket.Data
{
    public class MyLuckyTicketContext : DbContext
    {
        public MyLuckyTicketContext(DbContextOptions<MyLuckyTicketContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
    }
}