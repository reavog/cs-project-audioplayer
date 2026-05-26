using Microsoft.EntityFrameworkCore;
using AudioPlayer.Models;

namespace AudioPlayer.Data;

public class AudioPlayerDBContext : DbContext
{
    public AudioPlayerDBContext(DbContextOptions<AudioPlayerDBContext> options) : base(options)
    {

    }
    public DbSet<Song> Songs { get; set; } = default!;
}
