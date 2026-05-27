using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AudioPlayer.Data;
using AudioPlayer.Models;

namespace AudioPlayer.Controllers;

[Route("audio")]
[ApiController]
public class SongsController : ControllerBase
{
    private readonly AudioPlayerDBContext _context;

    public SongsController(AudioPlayerDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Song>>> GetAll()
    {
        return await _context.Songs.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Song>> GetbyId(int id)
    {
        var song = await _context.Songs.FindAsync(id);
        if (song == null)
            return NotFound();
        return song;
    }
}
