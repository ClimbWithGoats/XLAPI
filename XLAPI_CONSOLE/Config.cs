using Newtonsoft.Json;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.StaticController;

namespace XLAPI_CONSOLE
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attributes
    {
        public List<XLAtrKlasaNagInfoExt> commodities { get; set; }
        public List<XLAtrKlasaNagInfoExt> Contractors { get; set; }
        public List<XLAtrKlasaNagInfoExt> Documents { get; set; }
    }

    public class AttributesSql
    {
        public string FindClass { get; set; }
    }

    public class CategoriesSql
    {
        public string FindCategory { get; set; }
        public string FindTwrsbYCategory { get; set; }
    }

    public class CommoditiesSql
    {
        public string FindTwrByCode { get; set; }
        public string TwrModify { get; set; }
    }

    public class Commodity
    {
        public string JsonPropertyName { get; set; }
        public string Nazwa { get; set; }
        public int Typ { get; set; }
    }

    public class ConnectionStrings
    {
        public string DBContext { get; set; }
    }

    public class Contractor
    {
        public string JsonPropertyName { get; set; }
        public string Nazwa { get; set; }
        public int Typ { get; set; }
    }

    public class ContractorsSql
    {
        public string ContractorModify { get; set; }
        public string FindAccronym { get; set; }
    }

    public class Document
    {
        public string JsonPropertyName { get; set; }
        public string Nazwa { get; set; }
        public int Typ { get; set; }
    }

    public class DocumentsSql
    {
        public string DocumentsIsExists { get; set; }
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }

        [JsonProperty("Microsoft.AspNetCore")]
        public string MicrosoftAspNetCore { get; set; }
    }


    public class ConfigRoot
    {
        public string AllowedHosts { get; set; }
        public List<APIUsers> APIUsers { get; set; }
        public Attributes Attributes { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
        public Logging Logging { get; set; }
        public List<XLLoginInfo> OptimaUsers { get; set; }
        public SqlCommunications SqlCommunications { get; set; }
    }

    public class APIUsers
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class SqlCommunications
    {
        public AttributesSql AttributesSql { get; set; }
        public CategoriesSql CategoriesSql { get; set; }
        public CommoditiesSql CommoditiesSql { get; set; }
        public ContractorsSql ContractorsSql { get; set; }
        public DocumentsSql DocumentsSql { get; set; }
    }
}
