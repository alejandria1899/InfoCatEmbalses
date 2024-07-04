using System;
using System.Text.Json;
using Xunit;
using InfoCatEmbalses.Embalses;

namespace InfoCatEmbalses.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
     var embalse = new Embalse
     {
      Id = 1,
      Dia = new DateTime(2024, 7, 2),
      Estacio = "Embassament de Riudecanyes",
      NivellAbsolut = "193,94",
      PercentatgeVolumEmbassat = "2,1",
      VolumEmbassat = "0,11"
      };

      var json = JsonSerializer.Serialize(embalse);
      var deserializedEmbalse = JsonSerializer.Deserialize<Embalse>(json);


      Assert.NotNull(deserializedEmbalse);
      Assert.Equal(embalse.Id, deserializedEmbalse.Id);
      Assert.Equal(embalse.Dia, deserializedEmbalse.Dia);
      Assert.Equal(embalse.Estacio, deserializedEmbalse.Estacio);
      Assert.Equal(embalse.NivellAbsolut, deserializedEmbalse.NivellAbsolut);
      Assert.Equal(embalse.Percentatge);
      };


      var json = JsonSerializer.Serialize(embalse);


      Assert.Contains("\"id\":1", json);
      Assert.Contains("\"dia\":\"2024-07-04T00:00:00\"", json);
      Assert.Contains("\"estaci\":\"Embassament de Riudecanyes\"", json);
      Assert.Contains("\"nivell_absolut\":\"193,94\"", json);
      Assert.Contains("\"percentatge_volum_embassat\":\"2,1\"", json);
      Assert.Contains("\"volum_embassat\":\"0,11\"", json);
            }

            [Fact]
            public void Can_Deserialize_Embalse()
            {

                var json = @"
                {
                    ""id"": 1,
                    ""dia"": ""2024-07-04T00:00:00"",
                    ""estaci"": ""Embassament de Riudecanyes"",
                    ""nivell_absolut"": ""193,94"",
                    ""percentatge_volum_embassat"": ""2,1"",
                    ""volum_embassat"": ""0,11""
                }";


                var embalse = JsonSerializer.Deserialize<Embalse>(json);


                Assert.NotNull(embalse);
                Assert.Equal(1, embalse.Id);
                Assert.Equal(new DateTime(2024, 7, 4), embalse.Dia);
                Assert.Equal("Embassament de Riudecanyes", embalse.Estacio);
                Assert.Equal("193,94", embalse.NivellAbsolut);
                Assert.Equal("2,1", embalse.PercentatgeVolumEmbassat);
                Assert.Equal("0,11", embalse.VolumEmbassat);
            }
        }
    }

    }
}