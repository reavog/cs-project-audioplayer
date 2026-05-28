using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AudioPlayer.Data;
using AudioPlayer.Models;

namespace AudioPlayer.Controllers;

[Route("audio")]
[ApiController]
public class SongsController(AudioPlayerDBContext context) : ControllerBase
{


  [HttpGet]
  public async Task<ActionResult<List<Song>>> GetAll()
  {
    return await context.Songs.ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<Song>> GetbyId(int id)
  {
    var song = await context.Songs.FindAsync(id);
    if (song == null)
      return NotFound();
    return song;
  }
  [HttpGet("{id}/stream")]
  public async Task<IActionResult> Stream(int id)
  {
    var song = await context.Songs.FindAsync(id);
    if (song == null)
      return NotFound();

    var filePath = Path.Combine("home/miguel/Music", song.FilePath);
    var stream = System.IO.File.OpenRead(filePath);

    return File(stream, "audio/mpeg", enableRangeProcessing: true);
  }
}
