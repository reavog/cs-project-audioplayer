using Microsoft.AspNetCore.Mvc.RazorPages;
using AudioPlayer.Data;
using AudioPlayer.Models;
using Microsoft.EntityFrameworkCore;


namespace AudioPlayer.Pages;

public class IndexModel : PageModel
{
    private readonly AudioPlayerDBContext _context;
    public IndexModel(AudioPlayerDBContext context)
    {
        _context = context;
    }

    public List<Song> Songs { get; set; } = new();

    public async Task OnGetAsync()
    {
        Songs = await _context.Songs.ToListAsync();
    }
}
