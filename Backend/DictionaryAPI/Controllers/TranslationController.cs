using Microsoft.AspNetCore.Mvc;
using DictionaryAPI.Data;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TranslationController : ControllerBase
{
    private readonly AppDbContext _context;

    public TranslationController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{word}")]
    public async Task<IActionResult> GetTranslation(string word)
    {
        var translation = await _context.Translations
            .Where(t => t.English.Equals(word, StringComparison.OrdinalIgnoreCase))
            .FirstOrDefaultAsync();

        if (translation == null)
        {
            return NotFound("Translation not found");
        }

        return Ok(translation.Hungarian);
    }
}
