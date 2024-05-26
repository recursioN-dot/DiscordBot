using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Database.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public int PlaylistId { get; set; }
        public Playlist? Playlist { get; set; }
    }
}
