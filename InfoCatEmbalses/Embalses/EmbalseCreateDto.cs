using System.Text.Json.Serialization;

namespace InfoCatEmbalses.Embalses;

public class EmbalseCreateDto
{
    [JsonPropertyName("dia")]
    public DateTime Dia { get; set; }

    [JsonPropertyName("estaci")]
    public string Estacio { get; set; }

    [JsonPropertyName("nivell_absolut")]
    public string NivellAbsolut { get; set; }

    [JsonPropertyName("percentatge_volum_embassat")]
    public string PercentatgeVolumEmbassat { get; set; }

    [JsonPropertyName("volum_embassat")]
    public string VolumEmbassat { get; set; }
}