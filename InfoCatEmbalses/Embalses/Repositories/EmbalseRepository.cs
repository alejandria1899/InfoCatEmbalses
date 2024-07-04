using InfoCatEmbalses.Data;
using Microsoft.EntityFrameworkCore;

namespace InfoCatEmbalses.Embalses.Repositories;

public class EmbalseRepository : IEmbalseRepository
{
    private readonly AppDbContext _context;

    public EmbalseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Embalse>> GetAllEmbalse()
    {
        return await _context.Embalses.ToListAsync();
    }
    
    public async Task<List<Embalse>> GetAllFromLast5Days()
    {
        var fechaLimite = DateTime.Now.AddDays(-5);
        return await _context.Embalses
            .Where(e => e.Dia >= fechaLimite)
            .ToListAsync();
    }

    public async Task<int> CreateEmbalse(Embalse embalseDto)
    {
        _context.Add(embalseDto);
        await _context.SaveChangesAsync();
        return embalseDto.Id;
    }

    public async Task UpdateEmbalse(Embalse embalse)
    {
        _context.Update(embalse);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEmbalse(int id)
    {
        await _context.Embalses.Where(x => x.Id == id).ExecuteDeleteAsync();
    }
}