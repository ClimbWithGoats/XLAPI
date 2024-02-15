using Newtonsoft.Json;
using XLAPI_CONSOLE.StaticController;
namespace XLAPI_CONSOLE.Models
{
    public abstract class Doc : BaseXL
    {
        public string NumerPelny { get; set; } = "";
        public string NumeracjaDok { get; set; } = "";
        public string NumerString { get; set; } = "";
    }
    public abstract class BaseXL
    {
        [JsonIgnore]
        public int? Wersja { get => XLMainController.Wersja; }

        public int? OptimaId { get; set; }
        public int? OptimaTyp { get; set; }
        public int? GIDTyp { get; set; }
        public int? GIDFirma { get; set; }
        public int? GIDNumer { get; set; }
        public string OptimaDataOperacji { get; set; } = "";
        public string OptimaDataWystawienia { get; set; } = "";

        public abstract object JsonSerializeResult();

        [JsonIgnore]
        public string StatusZmiany { get; set; } = "";

    }
}