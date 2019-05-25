using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameServer.DBModels
{
    /// <summary>
    /// Represents the player entry in database
    /// </summary>
    public class Player
    {
        public int Id { get; set; }
        
        /// <summary>
        /// A name of this <see cref="Player"/>
        /// </summary>
        [Required, MaxLength(50)]
        public string Name { get; set; }
        
        /// <summary>
        /// A collection of <see cref="Item"/>s that this <see cref="Player"/>'s inventory contains
        /// </summary>
        public ICollection<Item> Items { get; set; }
        
        /// <summary>
        /// A collection of <see cref="GameSession"/>s that this <see cref="Player"/> participated in 
        /// </summary>
        public ICollection<GameSession> GameSessions { get; set; }
        
        /// <summary>
        /// Local path to the directory with <see cref="Player"/>'s sprites
        /// </summary>
        [Required]
        public string SpritePath { get; set; }

        public Player()
        {
            Items = new List<Item>();
            GameSessions = new List<GameSession>();
        }
    }
}