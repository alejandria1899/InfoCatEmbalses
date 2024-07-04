using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using InfoCatEmbalses.Data;
using InfoCatEmbalses.Embalses;
using Microsoft.Extensions.Logging;

public class EmbalseService
{
    private readonly HttpClient _httpClient;
    private readonly AppDbContext _context;
    private readonly ILogger<EmbalseService> _logger;

    public EmbalseService(HttpClient httpClient, AppDbContext context, ILogger<EmbalseService> logger)
    {
        _httpClient = httpClient;
        _context = context;
        _logger = logger;
    }

    public async Task ImportarDatosAsync()
    {
        try
        {
            var response = await _httpClient.GetStringAsync("https://analisi.transparenciacatalunya.cat/resource/gn9e-3qhr.json");
            var embalses = JsonSerializer.Deserialize<List<Embalse>>(response);

            foreach (var embalse in embalses)
            {
                if (string.IsNullOrEmpty(embalse.Estacio))
                {
                    _logger.LogWarning("Datos inválidos encontrados: {embalse}", embalse);
                    continue;
                }

                _context.Embalses.Add(embalse);
            }

            await _context.SaveChangesAsync();
            _logger.LogInformation("Datos guardados correctamente en la base de datos.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al importar datos.");
            throw;
        }
    }
}