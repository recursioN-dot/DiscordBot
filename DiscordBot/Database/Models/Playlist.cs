using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Database.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public ulong DiscordUserId { get; set; }
        public string? Name { get; set; }
        public List<Song>? Songs { get; set; }
    }
}
