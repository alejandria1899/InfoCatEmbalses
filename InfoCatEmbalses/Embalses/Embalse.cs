using System.Text.Json.Serialization;

namespace InfoCatEmbalses.Embalses;

public class Embalse
{
    // public int Id { get; set; }
    // public DateTime Dia { get; set; }
    // public string Estacio { get; set; }
    // public decimal NivellAbsolut { get; set; }
    // public decimal VolumEmbassat { get; set; }
    
    public int Id { get; set; }

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