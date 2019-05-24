using System.Data.Entity;
using GameServer.Models;

namespace GameServer
{
    public class PlatformerContext:DbContext
    {
        public PlatformerContext(string nameOrConnectionString) : base(nameOrConnectionString: nameOrConnectionString)
        {
            
        }

        public DbSet<Player> Players { get; set; }
        
        public DbSet<Item> Items { get; set; }
        
        public DbSet<GameSession> GameSessions { get; set; }
        
        public DbSet<Map> Maps { get; set; }
        
        public DbSet<Mission> Missions { get; set; }
        
        public DbSet<PlayerAppearance> PlayerAppearances { get; set; }
        
        public DbSet<Trade> Trades { get; set; }
    }
}