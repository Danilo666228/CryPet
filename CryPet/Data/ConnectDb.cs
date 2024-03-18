using System.Data.Entity;

namespace CryPet.Data
{
    public class ConnectDb : DbContext
    {
        public ConnectDb() : base("DbConnectionString")
        { 

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Coin> Coins { get; set; }
    }
}
