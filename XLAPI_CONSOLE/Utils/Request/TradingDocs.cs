using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.StaticController;

namespace XLAPI_CONSOLE.Utils.Request
{
    public class TradingDocs : Request
    {
        public TradingDocs()
        {
            Json = new List<XLDokumentNagInfo>();
        }
        public new List<XLDokumentNagInfo> Json { get; set; }

        public List<XLDokumentNagInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLDokumentNagInfo>>(base.Json) ?? new List<XLDokumentNagInfo>();
                }
            }
            catch
            {
                Console.WriteLine("GetContractors Exception");
            }

            return Json;
        }
        public override void SerializeToOutputMessage(List<object> list)
        {
            foreach (var item in Json)
            {
                list.Add(item.JsonSerializeResult());
            }
        }

        public override void StartXlOperations()
        {
            XLMainController.AddDocuments(Json, Guid);
        }
    }

}
