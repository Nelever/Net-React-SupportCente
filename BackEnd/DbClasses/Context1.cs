using Microsoft.EntityFrameworkCore;


namespace BackEnd
{
    //this is our database context and here we put connection string to our sql server
    public class MessageContext : DbContext
    {
        public DbSet<Userr>? Userrs { get; set; }
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<Moderator>? Mods { get; set; }
        public DbSet<Message>? Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("workstation id=support.mssql.somee.com;packet size=4096;user id=Neverel_SQLLogin_1;pwd=c4cs94xhhx;data source=support.mssql.somee.com;persist security info=False;initial catalog=support");
    }
    
}
