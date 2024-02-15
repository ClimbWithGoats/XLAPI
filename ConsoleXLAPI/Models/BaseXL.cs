

using ConsoleXLAPI.StaticController;
using System.Text.Json.Serialization;

namespace ConsoleXLAPI.Models
{
    public abstract class BaseXL
    {
        [JsonIgnore]
        public int? Wersja { get => XLMainController.Wersja; }



        public int? OptimaId { get; set; }
        public int? OptimaTyp { get; set; }
        public int? GIDTyp { get; set; }
        public int? GIDFirma { get; set; }
        public int? GIDNumer { get; set; }
        public string? OptimaDataOperacji { get; set; }
        public string? OptimaDataWystawienia { get; set; }
        //  public string? NumerPelny { get; set; }

        public abstract object JsonSerializeResult();

        [JsonIgnore]
        public string? StatusZmiany { get; set; }

    }
}