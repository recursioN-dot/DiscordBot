using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Database.Models
{
    public class User
    {
        public int Id { get; set; }
        public ulong DiscordUserId { get; set; }
        public string? Username { get; set; }
        public int Points { get; set; }
    }

}
