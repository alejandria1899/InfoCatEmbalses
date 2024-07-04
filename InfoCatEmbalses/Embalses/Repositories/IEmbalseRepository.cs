namespace InfoCatEmbalses.Embalses.Repositories;

public interface IEmbalseRepository
{
    Task<List<Embalse>> GetAllEmbalse();
    Task<List<Embalse>> GetAllFromLast5Days();
    Task<int> CreateEmbalse(Embalse embalseDto);
    Task UpdateEmbalse(Embalse embalse);
    Task DeleteEmbalse(int id);
}