using Microsoft.AspNetCore.Mvc.RazorPages;
using AudioPlayer.Data;
using AudioPlayer.Models;
using Microsoft.EntityFrameworkCore;


namespace AudioPlayer.Pages;

public class IndexModel(AudioPlayerDBContext context) : PageModel
{
  public List<Song> Songs { get; set; } = [];

  public async Task OnGetAsync()
  {
    Songs = await context.Songs.ToListAsync();
  }
}
